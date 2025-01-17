﻿using ApiApplication.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication.Database
{
    public interface IShowtimesRepository
    {
        //IEnumerable<ShowtimeEntity> GetCollection();
        //IEnumerable<ShowtimeEntity> GetCollection(Func<IQueryable<ShowtimeEntity>, bool> filter);
        //ShowtimeEntity GetByMovie(Func<IQueryable<MovieEntity>, bool> filter);
        //ShowtimeEntity Add(ShowtimeEntity showtimeEntity);
        //ShowtimeEntity Update(ShowtimeEntity showtimeEntity);
        //ShowtimeEntity Delete(int id);

        Task<IEnumerable<ShowtimeEntity>> GetCollection();
        Task<IEnumerable<ShowtimeEntity>> GetCollection(Func<IQueryable<ShowtimeEntity>, bool> filter);
        Task<ShowtimeEntity> GetByMovie(Func<IQueryable<MovieEntity>, bool> filter);
        Task<ShowtimeEntity> GetById(int id);
        Task<ShowtimeEntity> Add(ShowtimeEntity showtimeEntity);
        Task<ShowtimeEntity> Update(ShowtimeEntity showtimeEntity);
        Task<ShowtimeEntity> Delete(int id);
    }
}
