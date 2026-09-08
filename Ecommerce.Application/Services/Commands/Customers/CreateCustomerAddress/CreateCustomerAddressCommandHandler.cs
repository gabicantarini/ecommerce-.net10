using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Customers.CreateCustomerAddress
{
    public class CreateCustomerAddressCommandHandler
        : IHandler<CreateCustomerAddressCommand, ResultViewModel<Guid>>
    {
        //private readonly ICustomerRepository _repository;

        //public CreateCustomerAddressCommandHandler(ICustomerRepository repository)
        //{
        //    _repository = repository;
        //}

        public async Task<ResultViewModel<Guid>> HandleAsync(CreateCustomerAddressCommand request)
        {
            throw new NotImplementedException();
            //var address = new CustomerAddress(
            //    request.IdCustomer,
            //    request.RecipientName,
            //    request.AddressLine1,
            //    request.AddressLine2,
            //    request.ZipCode,
            //    request.District,
            //    request.State,
            //    request.City,
            //    request.Country);

            ////await _repository.CreateAddress(address);

            //return ResultViewModel<Guid>.Success(address.Id);
        }
    }
}
