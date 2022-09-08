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
using IndexHRMS.Domain.ResponseModel;
using IndexHRMS.Entity.Dtos;
using System.Reflection;
using IndexHRMS.Entity.Entities;

namespace IndexHRMS.Application.CommandQuery.Accounts.Queries.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseModel>
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
        public async Task<LoginResponseModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var userObj = await _iAccountsRepository.GetAsync(x => x.UserId == request.UserId);
            var user = userObj.FirstOrDefault();
            var data = _iMapper.Map<UserDto>(user);
            if (user == null)
                throw new Exception();
                //return await _iAccountsRepository.CheckDb();
			var computedPass = new PasswordManager().Decrypt(user.Password);

                if (computedPass != request.Password)
                    throw new Exception();

            var token = _iTokenRepository.CreateToken(user);
            return new LoginResponseModel
            {
                StatusCode = StringHelper.SuccessStatusCode,
                Message = StringHelper.LogedInSuccessMessage,
                Token = token,
                UserInfo = data,
            };
        }
    }
}
