Programų sistemų inžinerija IV
====
2014 m. pavasario semestras<br/>
Dėstytojas: <a href="http://uosis.mif.vu.lt/~plukas/">M. Plukas</a>

Pirma užduotis
=====
<ol>
<li>Esybės funkcionalumas yra varijuojamas tam tikru aspektu</li>
<li>Variacijos funkcionalumas aprašomos bent trimis operacijomis</li>
<li>Pritaikyti
<ul>
<li>Startegijos ("Strategy Method")</li>
<li>Metodo šablono ("Template Method")</li>
</ul> schemas funkcionalumui varijuoti. Palyginti abu variantus. <br/>
Pastaba: Nepriklausomai nuo to, koks variantas taikomas esybės funkcionalumui varijuoti, išorinis esybės funkcionalumas ir tai, kaip ją naudoja išoriniai klientai, yra tas pats.</li>
<li>Išnagrinėti situaciją, kai atsiranda <b>kita</b> esybė, varijuojama tuo pačiu funkcionalumu. Išnagrinėti abu variantus (t.y. Strategy ir Template Method taikymą), ar gali turimos variacijos būti panaudojamos su kita esybe ir kaip.</li>
</ol>

Antra užduotis
=====
<OL>
   <LI> Esybes, su rolėmis ar be jų, bendro funkcionalumo požiūriu galima naudoti vienodai
(per bendrą interfeisą).
   <LI> Esybė galėtų dinamiškai įgyti/prarasti roles.
   <LI> Rolių aibė būtų lengvai plečiama.
   <LI> Esybė galėtų vienu metu turėti keletą rolių. 
   <LI> Rolių(bent vienos) funkcionalumas turi būti toks, kad jo realizavimas reikalautų
tiesioginės sąveikos su pagrindinės esybės objektu -žr. 2 pavyzdį.
   <LI> Turi būti galimybė sužinoti ar esybė normą papildomą rolę ir, jei taip, tai esybę 
naudoti specifiškai(per rolės interfeisą).
</OL>
Problemą išspręskite dviem būdais (du projektai) - panaudodami projektines schemas DEKORATORIUS("Decorator") ir IŠPLĖTIMO OBJEKTAI ("Extension objects"). Aptarkite ir pademonstruokite, kaip tenkinami reikalavimai(pateikite pavyzdžių objektines diagramas).<br/>
Panagrinėkite ir palyginkite abu variantus.

Trečia užduotis
=====
Pasirinkti konkrečią situaciją: 
<UL>
<LI>Yra trys susijusios esybių hierarchijos - abstrakcijos ir skirtingai jas realizuojančios klasės.
<LI>Su kieviena abstrakčia esybe gali būti atliekami bent keli (2-3) polimorfiniai veiksmai - veiklos scenarijai (t.y. veiksmai, kurie atleika su esybe(esybėmis) kažką prasmingo, o ne esybės atributų nuskaitymo/įrašymo veiksmai); su konkrečiomis esybių klasėmis šie veiksmai vyksta skirtingai.
<LI>Šiuos veikmus, polimorfiškai - neprisirišdamos prie konkrečių esybių klasių, inicijuoja papildomos klientinės klasės arba  pačių esybių klasės (vienas veiklos scenarijus remiasi kitais scenarijais).
<LI>Pademonstruoti kaip ši situacija modeliuojam dviem būdais (realizuoti du projektus)
   <UL>
	<LI>Objektinis stilius: abstrakčiose esybėse įvedami veiklos scenarijus atitinkantys metodai, jie realizuojami poklasiuose.
	<LI>Duomenų struktūrų/servisų stilius: esybės yra duomenų struktūros, suteikiančios prieigą prie savo būseno, veiklos scenarijus atitinkantys metodai realizuojami atskirose servisų hierarchijose; naudojama "Servisų selektoriaus" schema konkrečioms servisų realizacijoms pagal konkrečią esybę polimorfiškai išrinkti. 
	</UL>
<LI>Palyginti abu variantus. Parodyti, kaip kiekviename projekte gali būti pridedamos naujos konkrečios esybių  realizacijos, kaip gali būti pridedami nauji veiksmai su esybėmis.
</UL>

VU MIF, PSI IV, 2014m. 
====
