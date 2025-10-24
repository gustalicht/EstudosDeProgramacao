using Microsoft.AspNetCore.Mvc;

public class TripController
{
    private readonly ITripService _tripService;

    public TripController(ITripService tripService)
    {
        _tripService = tripService;
    }

    public async Task<IActionResult> GetAllTrips()
    {

    }

    public async Task<IActionResult> GetTripById(int id)
    {

    }
    public async Task<IActionResult> CreateTrip(TripCreateDto tripCreateDto)
    {

    }
    public async Task UpdateTrips()
    {

    }

    public async Task<IActionResult> DeleteTrip(int id)
    {

    }
    


//outras formas de fazer controllers e metodos? 
sdsdsd












}