using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{

    public enum Countries
    {
        Afghanistan,
        AlandIslands,
        Albania,
        Algeria,
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        BosniaAndHerzegovina,
        Botswana,
        BouvetIsland,
        Brazil,
        BritishIndianOceanTerritory,
        BruneiDarussalam,
        Bulgaria,
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        CapeVerde,
        CaymanIslands,
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        ChristmasIsland,
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        CongoDemocraticRepublic,
        CookIslands,
        CostaRica,
        CoteDIvoire,
        Croatia,
        Cuba,
        Cyprus,
        CzechRepublic,
        Denmark,
        Djibouti,
        Dominica,
        DominicanRepublic,
        Ecuador,
        Egypt,
        ElSalvador,
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        FalklandIslands,
        FaroeIslands,
        Fiji,
        Finland,
        France,
        FrenchGuiana,
        FrenchPolynesia,
        FrenchSouthernTerritories,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guernsey,
        Guinea,
        GuineaBissau,
        Guyana,
        Haiti,
        HeardIslandMcdonaldIslands,
        HolySeeVaticanCityState,
        Honduras,
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        IsleOfMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jersey,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Korea,
        Kuwait,
        Kyrgyzstan,
        LaoPeoplesDemocraticRepublic,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        LibyanArabJamahiriya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macao,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        Micronesia,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        NetherlandsAntilles,
        NewCaledonia,
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        NorfolkIsland,
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        PalestinianTerritory,
        Panama,
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        PuertoRico,
        Qatar,
        Reunion,
        Romania,
        RussianFederation,
        Rwanda,
        SaintBarthelemy,
        SaintHelena,
        SaintKittsAndNevis,
        SaintLucia,
        SaintMartin,
        SaintPierreAndMiquelon,
        SaintVincentAndGrenadines,
        Samoa,
        SanMarino,
        SaoTomeAndPrincipe,
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        SolomonIslands,
        Somalia,
        SouthAfrica,
        SouthGeorgiaAndSandwichIsl,
        Spain,
        SriLanka,
        Sudan,
        Suriname,
        SvalbardAndJanMayen,
        Swaziland,
        Sweden,
        Switzerland,
        SyrianArabRepublic,
        Taiwan,
        Tajikistan,
        Tanzania,
        Thailand,
        TimorLeste,
        Togo,
        Tokelau,
        Tonga,
        TrinidadAndTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        TurksAndCaicosIslands,
        Tuvalu,
        Uganda,
        Ukraine,
        UnitedArabEmirates,
        UnitedKingdom,
        UnitedStates,
        UnitedStatesOutlyingIslands,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        VietNam,
        VirginIslandsBritish,
        VirginIslandsUS,
        WallisAndFutuna,
        WesternSahara,
        Yemen,
        Zambia,
        Zimbabw
    }

    public class User : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {

       

        public int Id { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String Address { get; set; }
        public String Password { get; set; }
        public override String Email { get; set; }      
        public Countries Countries { get; set; }
        public String Role { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public String Photo { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        {
            // Note the authenticationType must match the one defined in
            // CookieAuthenticationOptions.AuthenticationType 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 
            return userIdentity;
        }
    }

    public class CustomUserLogin : IdentityUserLogin<int>
    {
        public int Id { get; set; }

    }

    public class CustomUserRole : IdentityUserRole<int>
    {
        public int Id { get; set; }
    }

    public class CustomUserClaim : IdentityUserClaim<int>
    {

    }

    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }

}



 

