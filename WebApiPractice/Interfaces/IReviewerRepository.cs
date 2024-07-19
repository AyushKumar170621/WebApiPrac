﻿using WebApiPractice.Modals;

namespace WebApiPractice.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsbyReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
    }
}