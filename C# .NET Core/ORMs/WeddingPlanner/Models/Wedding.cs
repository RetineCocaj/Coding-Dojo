using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        public int WeddingId {get;set;}
        public string Groom {get;set;}
        public string Bride {get;set;}
        
        [DataType(DataType.Date)]
        [FutureDate]
        public DateTime Date {get;set;}
        public string Address {get;set;}
        public int UserId {get;set;}
        public User Planner {get;set;}
        public List<Response> Responses {get;set;}
    }
    public class Response
    {
        public int ResponseId {get;set;}
        public int WeddingId {get;set;}
        public int UserId {get;set;}
        public User Guest {get;set;}
    }
}