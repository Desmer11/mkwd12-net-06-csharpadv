﻿using QinshiftAcademy.TryBeingFit.Domain.Database;
using QinshiftAcademy.TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDatabase<T> _database;
        public UserService()
        {
            _database = new Database<T>();
        }

        public T ChangeInfo(int userId, string firstName, string lastName)
        {
            T userDb = GetById(userId);
            if(!ValidationHelper.ValidateName(firstName) || !ValidationHelper.ValidateName(lastName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return null;
            }
            userDb.FirstName = firstName;
            userDb.LastName = lastName;
            _database.Update(userDb);
            MessageHelper.PrintMessage($"User with id {userId} was successfully updated", ConsoleColor.Green);
            return _database.GetById(userId);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _database.GetById(id);
        }

        public T Login(string username, string password)
        {
            T userDb = _database.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if(userDb == null)
            {
                MessageHelper.PrintMessage($"[Error User with username {username} does not exists", ConsoleColor.Red);
                return null;
            }
            return userDb;
        }

        public T Register(T userModel)
        {
            if(!ValidationHelper.ValidateName(userModel.FirstName) || !ValidationHelper.ValidateName(userModel.LastName)
                                                                   || !ValidationHelper.ValidateUserName(userModel.Username)
                                                                   || !ValidationHelper.ValidatePassword(userModel.Password))
            {
                MessageHelper.PrintMessage("[Error] User data is invalid", ConsoleColor.Red);
                return null;
            }
            int id = _database.Insert(userModel);
            return _database.GetById(id);
        }

        public void RemoveById(int id)
        {
            _database.DeleteById(id);
        }
    }
}
