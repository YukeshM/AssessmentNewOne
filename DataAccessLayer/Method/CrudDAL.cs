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

                //using (var sqlConnection = new SqlConnection(_connectionString))
                //{
                //    sqlConnection.Query<Event>("EXECUTE CreateEvent User_Id, EventType_Id, Title, Description, Address, City, Owner, StartDateTime , EndDateTime",
                //        new
                //        {
                //            model.UserId,
                //            model.EventTypeId,
                //            model.Title,
                //            model.Description,
                //            model.Address,
                //            model.City,
                //            model.Owner,
                //            model.StartDateTime,
                //            model.EndDateTime
                //        });
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


        public Event Get(int id)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    var model = sqlConnection.Query<Event>("EXECUTE GetEventById @Id",
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

        public void Delete(AdminViewModel model)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {

                    sqlConnection.Query("EXECUTE DeleteEvent @Id", new
                    {
                        @Id = model.Id
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
