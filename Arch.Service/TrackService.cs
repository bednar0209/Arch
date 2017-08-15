using Arch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Repository;

namespace Arch.Service
{
    public class TrackService : EntityService<Track>, ITrackService
    {
        IUnitOfWork _unitOfWork;
        ITrackRepository _trackRepository;

        public TrackService(IUnitOfWork unitOfWork, ITrackRepository repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _trackRepository = repository;
        }
    }
}
