using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using eTickets.Data.Services;
using eTickets.Models;



namespace eTickets.Data.Base
{
    public interface IEntityBase
    {

        int Id { get; set; }

    }
}
