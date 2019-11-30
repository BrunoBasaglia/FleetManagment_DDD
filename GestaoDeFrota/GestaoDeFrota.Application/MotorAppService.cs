using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class MotorAppService : AppServiceBase<Motor>, IMotorAppService
    {
        public IMotorService _motorService;

        public MotorAppService(IMotorService motorService) : base(motorService)
        {
            _motorService = motorService;
        }
    }
}
