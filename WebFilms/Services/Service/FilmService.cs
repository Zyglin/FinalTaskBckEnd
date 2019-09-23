﻿using System;
using System.Collections.Generic;
using WebFilms.DataAccess.DbPatterns.Interfaces;
using WebFilms.DataAccess.Entity;
using WebFilms.Services.Interface;

namespace WebFilms.Services.Service
{
    public class FilmService:ServiceConstructor,IFilmService
    {
        public FilmService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IEnumerable<Film> GetAllFilms()
        {
            return UnitOfWork.Films.GetAll();
        }

        public Film GetFilm(Guid id)
        {
            return UnitOfWork.Films.Get(id);
        }
    }
}
