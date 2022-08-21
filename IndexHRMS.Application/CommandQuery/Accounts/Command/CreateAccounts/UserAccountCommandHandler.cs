using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IndexHRMS.Application.Enums;
using IndexHRMS.Application.Helper;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;

namespace IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts
{
    public class UserAccountCommandHandler : IRequestHandler<UserAccountCommand, Message>
    {
        private readonly IMapper _iMapper;
        private readonly IAccountsRepository _iAccountsRepository;

        public UserAccountCommandHandler(IMapper iMapper, IAccountsRepository iAccountsRepository)
        {
            _iMapper = iMapper;
            _iAccountsRepository = iAccountsRepository;
        }

        public async Task<Message> Handle(UserAccountCommand request, CancellationToken cancellationToken)
        {
            Message message = null;

            using var hmac = new HMACSHA512();
            var user = _iMapper.Map<User>(request);

            user.Password = new PasswordManager().Encrypt(request.Password);
            user.AddedDate = DateTime.Now;
            user.Id = Guid.NewGuid().ToString();
            try
            {
                var register = await _iAccountsRepository.AddAsync(user);
                if (register.Id is not null)
                {
                    message = new Message()
                    {
                        StatusCode = Convert.ToInt32(HttpStatusCode.OK),
                        StatusMessage = "Data saved successfully"
                    };
                }
                return message;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
