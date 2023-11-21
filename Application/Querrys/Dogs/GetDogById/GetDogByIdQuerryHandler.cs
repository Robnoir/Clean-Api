using Application.Quarrys.Dogs.GetAllDogs;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Querrys.Dogs.GetDogById
{
    public class GetDogByIdQuerryHandler : IRequestHandler<GetDogByIdQuerry, Dog>
    {
        private readonly MockDatabase _mockDatabase;

        public GetDogByIdQuerryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Dog> Handle(GetDogByIdQuerry request, CancellationToken cancellationToken)
        {

            Dog wantedDog = _mockDatabase.allDogs.Where(Dog => Dog.animalID == request.Id).FirstOrDefault()!;
            return Task.FromResult(wantedDog);


        }
    }
}
