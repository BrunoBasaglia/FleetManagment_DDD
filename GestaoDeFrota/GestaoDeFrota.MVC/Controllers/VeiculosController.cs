using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.MVC.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestaoDeFrota.MVC.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVeiculoAppService _veiculoAppService;
        private readonly IOrigemAppService _origemAppService;
        private readonly ICambioAppService _cambioAppService;
        private readonly ICategoriaAppService _categoriaAppService;
        private readonly IClasseAppService _classeAppService;
        private readonly ICombustivelAppService _combustivelAppService;
        private readonly IModeloAppService _modeloAppService;
        private readonly IMotorAppService _motorAppService;
        private readonly IFabricanteAppService _fabricanteAppService;
        private readonly IImagemAppService _imagemAppService;

        private readonly IHostingEnvironment _env;

        public VeiculosController(IMapper mapper, IVeiculoAppService veiculo, ICambioAppService cambio, IOrigemAppService origem,
            ICategoriaAppService categoria, IClasseAppService classe, ICombustivelAppService combustivel, IModeloAppService modelo,
            IMotorAppService motor, IFabricanteAppService fabricante, IImagemAppService imagem, IHostingEnvironment env)
        {
            _mapper = mapper;
            _cambioAppService = cambio;
            _veiculoAppService = veiculo;
            _origemAppService = origem;
            _categoriaAppService = categoria;
            _classeAppService = classe;
            _combustivelAppService = combustivel;
            _modeloAppService = modelo;
            _motorAppService = motor;
            _fabricanteAppService = fabricante;
            _imagemAppService = imagem;
            _env = env;
        }

        public void Bags()
        {
            ViewBag.Fabricante = new SelectList(_fabricanteAppService.GetAll(), "Id", "Nome");
            ViewBag.Modelo = new SelectList(_modeloAppService.GetAll(), "Id", "Nome");
            ViewBag.Motor = new SelectList(_motorAppService.GetAll(), "Id", "Motorizacao");
            ViewBag.Combustivel = new SelectList(_combustivelAppService.GetAll(), "Id", "Nome");
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "Id", "Tipo");
            ViewBag.Classe = new SelectList(_classeAppService.GetAll(), "Id", "Classificacao");
            ViewBag.Origem = new SelectList(_origemAppService.GetAll(), "Id", "Procedencia");
            ViewBag.Cambio = new SelectList(_cambioAppService.GetAll(), "Id", "Tipo");
        }

        // GET: Veiculo
        [HttpPost]
        public ActionResult Modelos(int id)
        {
            //var modelos = new SelectList(_modeloAppService.GetAll(), "Id", "Nome");
            var modelos = _modeloAppService.GetAll().Where(v => v.FabricanteId == id);

            //return Ok(modelos);
            return Json(modelos);
        }

        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculoViewModel = _mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.Veiculos());
            return View(veiculoViewModel);
        }

        // GET: Veiculo/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var veiculo = _veiculoAppService.Veiculo(id);
                var veiculoViewModel = _mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
                return View(veiculoViewModel);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            Bags();
            return View();
        }

        // POST: Veiculo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VeiculoViewModel veiculo)
        {

            //TO DO
            //VERIFICAR SE PLACA JÁ EXISTE

            if (ModelState.IsValid)
            {
                var veiculoDomain = _mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Add(veiculoDomain);


                if (veiculo.Img != null)
                {
                    string diretorio = _env.WebRootPath + "\\Files\\" + veiculoDomain.Id.ToString();

                    if (!Directory.Exists(diretorio))
                        Directory.CreateDirectory(diretorio);

                    var imagem = new Imagem(veiculo.Img.FileName, diretorio, veiculo.Img.ContentType, veiculoDomain.Id);
                    string arquivo = diretorio + "\\" + imagem.Arquivo;
                    var stream = new FileStream(arquivo, FileMode.Create);
                    await veiculo.Img.CopyToAsync(stream);
                    _imagemAppService.Add(imagem);
                }
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Bags();
                var veiculo = _veiculoAppService.GetById(id);
                var veiculoViewModel = _mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
                return View(veiculoViewModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // POST: Veiculo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int id)
        {
            var veiculo = _veiculoAppService.Veiculo(id);
            var veiculoViewModel = _mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            _veiculoAppService.Remove(veiculo);


            //TO DO
            //DELETAR IMAGEM DO VEÍCULO

            return RedirectToAction("Index");
        }
    }
}