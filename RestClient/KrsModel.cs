using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HumanFactor
{
    public class KrsModel
    {
        [JsonProperty(PropertyName = "krs_podmioty.data_wyrejestrowania_przedsiebiorcy")]
        public string Data_wyrejestrowania_przedsiebiorcy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_wykreslenia_stowarzyszenia")]
        public string data_wykreslenia_stowarzyszenia { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_sprawdzenia")]
        public string data_sprawdzenia { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_lokal")]
        public string adres_lokal { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_miejscowosc")]
        public string adres_miejscowosc { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_czlonkow_komitetu_zal")]
        public string liczba_czlonkow_komitetu_zal { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.regon")]
        public string regon { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.akcept")]
        public string akcept { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.forma_prawna_typ_id")]
        public string forma_prawna_typ_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_zmian_umow")]
        public string liczba_zmian_umow { get; set; }
    
            [JsonProperty(PropertyName = "krs_podmioty.siedziba")]
        public string siedziba { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wartosc_kapital_zakladowy")]
        public int wartosc_kapital_zakladowy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.rejestr_stowarzyszen")]
        public string rejestr_stowarzyszen { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nazwa")]
        public string nazwa { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_kod_pocztowy")]
        public string adres_kod_pocztowy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.empty")]
        public string empty { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nip")]
        public string nip { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_prokurentow")]
        public string liczba_prokurentow { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nieprzedsiebiorca")]
        public string nieprzedsiebiorca { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.www")]
        public string www { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.forma_prawna_str")]
        public string forma_prawna_str { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nazwa_organu_reprezentacji")]
        public string nazwa_organu_reprezentacji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wczesniejsza_rejestracja_str")]
        public string wczesniejsza_rejestracja_str { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres")]
        public string adres { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_akcji_wszystkich_emisji")]
        public string liczba_akcji_wszystkich_emisji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.dotacje_ue_beneficjent_id")]
        public string dotacje_ue_beneficjent_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_emisji_akcji")]
        public string liczba_emisji_akcji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.twitter_account_id")]
        public string twitter_account_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_dokonania_wpisu")]
        public string data_dokonania_wpisu { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nazwa_organu_nadzoru")]
        public string nazwa_organu_nadzoru { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wartosc_czesc_kapitalu_wplaconego")]
        public int wartosc_czesc_kapitalu_wplaconego { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.rejestr")]
        public string rejestr { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wartosc_nominalna_podwyzszenia_kapitalu")]
        public int wartosc_nominalna_podwyzszenia_kapitalu { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_rejestracji_przedsiebiorcy")]
        public string data_rejestracji_przedsiebiorcy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.firma")]
        public string firma { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.opp")]
        public string opp { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_dzialalnosci")]
        public string liczba_dzialalnosci { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.numer_wpisu")]
        public string numer_wpisu { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.deleted_on_request")]
        public string deleted_on_request { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_ulica")]
        public string adres_ulica { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_jedynych_akcjonariuszy")]
        public string liczba_jedynych_akcjonariuszy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_rejestracji_stowarzyszenia")]
        public string data_rejestracji_stowarzyszenia { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_nadzorcow")]
        public string liczba_nadzorcow { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.sposob_reprezentacji")]
        public string sposob_reprezentacji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wykreslony")]
        public string wykreslony { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.gmina_id")]
        public string gmina_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wojewodztwo_id")]
        public string wojewodztwo_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_zmian")]
        public string liczba_zmian { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.sygnatura_akt")]
        public string sygnatura_akt { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_wspolnikow")]
        public string liczba_wspolnikow { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.cel_dzialania")]
        public string cel_dzialania { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.nazwa_skrocona")]
        public string nazwa_skrocona { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_ostatni_wpis")]
        public string data_ostatni_wpis { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_reprezentantow")]
        public string liczba_reprezentantow { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.email")]
        public string email { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_poczta")]
        public string adres_poczta { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.kod_pocztowy_id")]
        public string kod_pocztowy_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_wpisu_opp")]
        public string data_wpisu_opp { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wartosc_kapital_docelowy")]
        public int wartosc_kapital_docelowy { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_numer")]
        public string adres_numer { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.powiat_id")]
        public string powiat_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.adres_kraj")]
        public string adres_kraj { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.wartosc_nominalna_akcji")]
        public int wartosc_nominalna_akcji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.gpw_spolka_id")]
        public string gpw_spolka_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.miejscowosc_id")]
        public string miejscowosc_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.knf_ostrzezenie_id")]
        public string knf_ostrzezenie_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.krs")]
        public string krs { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_zawieszenia_dzialanosci")]
        public string data_zawieszenia_dzialanosci { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_rejestracji")]
        public string data_rejestracji { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.ostatni_wpis_id")]
        public string ostatni_wpis_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_uprawomocnienia_wykreslenia")]
        public string data_uprawomocnienia_wykreslenia { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.forma_prawna_id")]
        public string forma_prawna_id { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.liczba_oddzialow")]
        public string liczba_oddzialow { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.data_wznowienia_dzialanosci")]
        public string data_wznowienia_dzialanosci { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.umowa_spolki_cywilnej")]
        public string umowa_spolki_cywilnej { get; set; }

        [JsonProperty(PropertyName = "krs_podmioty.oznaczenie_sadu")]
        public string oznaczenie_sadu { get; set; }
    }

    public class DataObject
    {
        public string id { get; set; }
        public string dataset { get; set; }
        public string url { get; set; }
        public string mp_url { get; set; }
        public string schema_url { get; set; }
        public string global_id { get; set; }
        public string slug { get; set; }
        public string score { get; set; }
        public KrsModel data { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string next { get; set; }
        public string last { get; set; }
    }

    public class RootObject
    {
        public List<DataObject> DataObject { get; set; }
        public int Count { get; set; }
        public int Took { get; set; }
        public Links Links { get; set; }
    }

}
