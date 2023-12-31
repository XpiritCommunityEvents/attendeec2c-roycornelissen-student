﻿using System;

namespace GloboTicket.Frontend.Models.Api
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Artist Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
