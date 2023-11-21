using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Quarrys.Dogs.GetAllDogs
{

    public class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuerry, List<Dog>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllDogsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<List<Dog>> Handle(GetAllDogsQuerry request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMockDB = _mockDatabase.allDogs;
            return Task.FromResult(allDogsFromMockDB);
        }
    }
}
