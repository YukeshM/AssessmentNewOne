using Dapper;
using DataAccessLayer.Entity;
using DataAccessLayer.Interface;
using DataAccessLayer.ViewModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer.Method
{

    public class CrudDAL : ICrudDAL
    {

        private readonly string _connectionString;

        public CrudDAL(string connectionString)
        {
            this._connectionString = connectionString;
        }


        #region Create event
        /// <summary>
        /// method for creating new event
        /// </summary>
        /// <param name="Event"></param>
        /// 
        public void Create(AdminViewModel model)
        {

            try
            {
                var storedProcedure = "CreateEvent";
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute(storedProcedure,
                    new
                    {
                        @User_Id = model.UserId,
                        @EventType_Id = model.EventTypeId,
                        @Title = model.Title,
                        @Description = model.Description,
                        @Address = model.Address,
                        @City = model.City,
                        @Owner = model.Owner,
                        @StartDateTime = model.StartDateTime,
                        @EndDateTime = model.EndDateTime
                    }, commandType: CommandType.StoredProcedure);


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


        public AdminViewModel Get(int id)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    var model = sqlConnection.Query<AdminViewModel>("EXECUTE GetEventById @Id",
                        new
                        {
                            @Id = id
                        }).FirstOrDefault();
                    return model;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<AdminViewModel> GetAll()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    var model = sqlConnection.Query<AdminViewModel>("EXECUTE GetAllEvents").ToList();
                    return model;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(AdminViewModel model)
        {
            try
            {
                var storedProcedure = "EditEvent";
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute(storedProcedure,
                    new
                    {
                        @Id = model.Id,
                        @User_Id = model.UserId,
                        @EventType_Id = model.EventTypeId,
                        @Title = model.Title,
                        @Description = model.Description,
                        @Address = model.Address,
                        @City = model.City,
                        @Owner = model.Owner,
                        @StartDateTime = model.StartDateTime,
                        @EndDateTime = model.EndDateTime
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {

                    sqlConnection.Query("EXECUTE DeleteEvent @Id", new
                    {
                        @Id = id
                    });

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
