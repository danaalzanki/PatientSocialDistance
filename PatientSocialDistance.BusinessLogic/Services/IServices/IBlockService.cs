﻿using PatientSocialDistance.Persistence.DTOs;
using PatientSocialDistance.Persistence.NotDbModels;

namespace PatientSocialDistance.BusinessLogic.Services.IServices
{
    public interface IBlockService
    {
        Task<bool> CheckBlockAsync(string userWantToCheck, string userTockeckIt);
        Task<Result> GetAllAsync(string user);

        Task<Result> CreateOrDeleteBlockAsync(BlockUserDto blockUserDto);
    }
}
