using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class MotorService : ServiceBase<Motor>, IMotorService
    {
        private IMotorRepository _motorRepository;

        public MotorService(IMotorRepository motorRepository) : base(motorRepository)
        {
            _motorRepository = motorRepository;
        }
    }
}
