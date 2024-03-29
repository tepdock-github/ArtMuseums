﻿using ArtMuseum;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class TourRepository : RepositoryBase<Tour>, ITourRepository
    {
        public TourRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public async Task<Tour?> GetTour(string tourId, bool trackChanges)=>
            await FindByCondition(t => t.Id.Equals(tourId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<PagedList<Tour>> GetAllTours(string exhibitionId, ToursParameters toursParameters,
            bool trackChanges)
        {
            var tours = await FindByCondition(t => t.TourPlaces >= toursParameters.MinPlaces &&
            t.TourPlaces <= toursParameters.MaxPlaces && t.ExhibitionId.Equals(exhibitionId), trackChanges)
                .Sort(toursParameters.OrderBy)
                .ToListAsync();

            return PagedList<Tour>
                .ToPagedList(tours, toursParameters.PageNumber, toursParameters.PageSize);
        }

        public async Task<Tour?> GetTourByDescr(string descr, bool trackChanges) =>
            await FindByCondition(t => t.Description.Equals(descr), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateTour(Tour tour) => Create(tour);
        public void DeleteTour(Tour tour) => Delete(tour);
    }
}
