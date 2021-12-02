using Albina.BusinessLogic.Core.Interfaces;
using Albina.BusinessLogic.Core.Models;
using AutoMapper;
using Kisik.DataAccess.Core.Interfaces;
using Kisik.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using Shareds.Exceptions;
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

        public async Task<UserInformationBlo> Get(int userId)
        {
            userRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user == null) throw new NotFoundException($"Пользователь с id {userId} не найден") ;
            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);           
            return UserInformationBlo;

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
