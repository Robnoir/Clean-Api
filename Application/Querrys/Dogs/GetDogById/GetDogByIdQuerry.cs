using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Querrys.Dogs.GetDogById
{
    public class GetDogByIdQuerry : IRequest<Dog>
    {
        public GetDogByIdQuerry(Guid dogid)
        {
            Id = dogid;
        }

        public Guid Id { get; set; }
    }

}
