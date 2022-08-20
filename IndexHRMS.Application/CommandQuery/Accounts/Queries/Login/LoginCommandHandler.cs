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
using IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts;
using IndexHRMS.Application.Helper;
using IndexHRMS.Application.Interfaces;

namespace IndexHRMS.Application.CommandQuery.Accounts.Queries.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IMapper _iMapper;
        private readonly IAccountsRepository _iAccountsRepository;
        private readonly ITokenRepository _iTokenRepository;

        public LoginCommandHandler(IMapper iMapper, IAccountsRepository iAccountsRepository, ITokenRepository iTokenRepository)
        {
            _iMapper = iMapper;
            _iAccountsRepository = iAccountsRepository;
            _iTokenRepository = iTokenRepository;
        }
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var userObj = await _iAccountsRepository.GetAsync(x => x.UserName == request.UserName);
            var user = userObj.FirstOrDefault();
            if (user == null)
                throw new Exception();
			var hmac = new HMACSHA512(user.Password);
			var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != hmac.Hash[i])
                    throw new Exception();
            }

            return _iTokenRepository.CreateToken(user);
        }
    }
}
