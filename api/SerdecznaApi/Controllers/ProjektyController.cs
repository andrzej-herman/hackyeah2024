using Microsoft.AspNetCore.Mvc;

namespace SerdecznaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjektyController : ControllerBase
    {
        private static List<Projekt> projekty = new List<Projekt>()
        {
            new Projekt( @"Serdeczne Talenty",@"Fundacja Hearty i UBS",@"Aby wspiera? wiar? w siebie i mi?o?? do nauki, wraz z firm? UBS zbudowali?my projekt, kt�ry skupia si? na warsztatach rozwijaj?cych pasje, interakcjach z wolontariuszami i zaj?ciach dodatkowych. Zwie?czeniem podr�?y jest Gala Serdecznych Talent�w w Krakowie, Wroc?awiu i Warszawie, celebruj?ca ich rozw�j i osi?gni?cia.",@"https://serdeczna.org/heartytalents/" ),
            new Projekt( @"Future Innovators Academy",@"Fundacja Hearty i UBS",@"Stworzyli?my FIA razem z firm? UBS, aby zainspirowa? dzieci i m?odzie? do poszerzania horyzont�w, rozwijania talent�w i budowania wiary we w?asne mo?liwo?ci. ",@"https://serdeczna.org/future-innovators-academy/" ),

        };

    private readonly ILogger<ProjektyController> _logger;

    public ProjektyController(ILogger<ProjektyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProjekty")]
    public IEnumerable<Projekt> Get()
    {
        return projekty;
    }
}
}
