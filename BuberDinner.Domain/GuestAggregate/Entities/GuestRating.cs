using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.GuestAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.GuestAggregate.Entities
{
    public sealed class GuestRating : Entity<GuestRatingId>
    {
        public HostId HostId { get; }
        public DinnerId DinnerId { get; }
        public int Rating {  get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }
        private GuestRating(
            GuestRatingId guestRatingId, 
            HostId hostId, 
            DinnerId dinnerId,
            int rating,
            DateTime createdDateTime,
            DateTime updatedDateTime) : base(guestRatingId)
        {
            HostId = hostId;
            DinnerId = dinnerId;
            Rating = rating;
        }

        public static GuestRating Create(
            HostId hostId,
            DinnerId dinnerId,
            int rating)
        {
            return new GuestRating(
                    GuestRatingId.CreateUnique(),
                    hostId,
                    dinnerId,
                    rating,
                    DateTime.UtcNow,
                    DateTime.UtcNow
                );
        }
    }
}
