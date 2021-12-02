using Albina.BusinessLogic.Core.Interfaces;
using Albina.BusinessLogic.Core.Models;
using AutoMapper;
using Kisik.DataAccess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinessLogic.Services
{
    public class UserServices : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _context;

        public UserServices(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo)
        {
            
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            _context.Users
        }

        public Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserIdentityBlo userIdentityBlo, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
            
        }
    }
}
