using Arch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Repository;

namespace Arch.Service
{
    public class ArtistService : EntityService<Artist>, IArtistService
    {
        IUnitOfWork _unitOfWork;
        IArtistRepository _artistRepository;

        public ArtistService(IUnitOfWork unitOfWork, IArtistRepository repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _artistRepository = repository;
        }
    }
}
