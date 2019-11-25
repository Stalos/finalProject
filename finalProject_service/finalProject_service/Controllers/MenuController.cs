using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using finalProject_service.Models;


namespace finalProject_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        [HttpGet("dishes/{section}")]
        public ActionResult<dish> GetDishesBySection(string section)
        {
            List<dish> allMenu = getAllDishes();
            var filteredMenu = from dish d in allMenu
                               where d.section == section
                               select d;
            return Ok(filteredMenu);
        }
        // DONE: deserts, starters,  main course, salats, pizzas, sandwiches, kids,            
        //LEFT: 
        private List<dish> getAllDishes()              
            {
            List<dish> myDishes = new List<dish>();

                // get deserts
                dish desert_soufle = new dish("Soufle", "with cream", "Deserts", "hot soufle with cream", 35, "https://cdn.kiwilimon.com/recetaimagen/1685/th5-640x426-12888.jpg");
                dish desert_cheeseCake = new dish("Cheese Cake", "with chocolate", "Deserts", "cheese cake with chocolate", 35, "https://www.jocooks.com/wp-content/uploads/2018/11/new-york-style-cheesecake-1-2.jpg");
                dish desert_troufles = new dish("troufles", "with pineapple", "Deserts", "brownies with pineapple and cream", 35, "https://www.averiecooks.com/wp-content/uploads/2019/04/boyfriendbrownies-6.jpg");
                dish desert_applePie = new dish("Apple Pie", "with meipel", "Deserts", "hot apple-pie with meipel", 35, "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2013/6/28/0/FNK_Apple-Pie_s4x3.jpg.rend.hgtvcom.826.620.suffix/1382545039107.jpeg");

                // get starters
                dish firstDish_Fries = new dish("Fries", "like homefries", "Starters", "asd", 36, "https://thumbor.thedailymeal.com/r19Dr1epeqxTZm6O5CuFj0T0kME=//https://www.thedailymeal.com/sites/default/files/recipe/2018/iStock-687999118_1_.jpg");
                dish firstDish_Nachos = new dish("Cheese Nachos", "with cheese", "Starters", "hot nachos with melted cheese", 35, "https://img1.mashed.com/img/gallery/mistakes-everyone-makes-when-making-nacho-cheese/intro-1544049574.jpg");
                dish firstDish_NachosSupreme = new dish("Nachos Supreme", "with vegtebles", "Starters", "nachos with melted cheese and veg", 55, "http://www.pamperedchef.ca/iceberg/com/recipe/1050281-lg.jpg");
                dish firstDish_NachosSupremeTexas = new dish("Nachos Supreme Texas", "with beef", "Starters", "nachos with cheese, veg and beef", 62, "https://www.farmison.com/community/wp-content/uploads/2018/06/BEEF-CHILI-TACO-NACHOS-AND-TORTILLA-NACHOS-1024x1024.jpg");
                dish firstDish_Sausege = new dish("Sausege", "on cabage", "Starters", "2 sauseges on a hot skillet", 42, "https://www.wikihow.com/images/thumb/0/0a/Cook-Italian-Sausage-Step-4-Version-2.jpg/aid2339691-v4-728px-Cook-Italian-Sausage-Step-4-Version-2.jpg");
                dish firstDish_MunchiesBusket = new dish("Munchies Busket", "mix fries", "Starters", "fries, onion rings and chicken fingers", 52, "https://image.shutterstock.com/image-photo/breaded-chicken-strips-french-fries-260nw-165016274.jpg");
                dish firstDish_MacNCheese = new dish("Mac n Cheese", "macaroni and cheese", "Starters", "macaroni and cheese", 49, "https://www.dinneratthezoo.com/wp-content/uploads/2018/04/stove-top-mac-and-cheese-4.jpg");
                dish firstDish_Adamame = new dish("Adamame", "with salt", "Starters", "big plate of adamame", 39, "https://www.garlicandzest.com/wp-content/uploads/2014/02/blistered-edamame-9.jpg");
                dish firstDish_BBQwings8 = new dish("BBQ wings 8 pieces", "8 wings with BBQ sauce", "Starters", "8 wings with bbq", 39, "https://img.sndimg.com/food/image/upload/w_555,h_416,c_fit,fl_progressive,q_95/v1/img/recipes/18/58/92/apYqQ1tfTWaLP3tlxrxQ_bbq%20chic3.jpg");
                dish firstDish_BBQwings16 = new dish("BBQ wings 16 pieces", "16 wings with BBQ sauce", "Starters", "16 wings with bbq", 52, "https://img.sndimg.com/food/image/upload/w_555,h_416,c_fit,fl_progressive,q_95/v1/img/recipes/18/58/92/apYqQ1tfTWaLP3tlxrxQ_bbq%20chic3.jpg");
                dish firstDish_Hotwings8 = new dish("Hot wings 8 pieces", "8 wings with frank sauce", "Starters", "8 wings with frank hot sauce", 42, "https://img.sndimg.com/food/image/upload/w_555,h_416,c_fit,fl_progressive,q_95/v1/img/recipes/18/58/92/apYqQ1tfTWaLP3tlxrxQ_bbq%20chic3.jpg");
                dish firstDish_HotWings16 = new dish("Hot wings 16 pieces", "16 wings with frank sauce", "Starters", "16 wings with franks hot sauce", 56, "https://www.thespruceeats.com/thmb/-xzu1qCwP2_eLYw4QbaJt2yW7F8=/450x0/filters:no_upscale():max_bytes(150000):strip_icc()/traditional-chicken-wings-912937-10-5b3f8c9ac9e77c00547241ab.jpg");
                dish firstDish_CheeseFries = new dish("Cheese fries", "fries with melted cheese", "Starters", "fries with melted cheese", 42, "https://upload.wikimedia.org/wikipedia/commons/0/03/Shake_shack_cheese_fries.jpg");
                dish firstDish_CheeseBaconFries = new dish("Cheese bacon fries", "fries with cheese and bacon", "Starters", "fries with cheese and bacon", 52, "http://i0.wp.com/chickandhercheese.com/wp-content/uploads/2016/03/Bacon-ranch-cheese-fries-08.jpg");
                dish firstDish_OnionRings = new dish("Onion rings", "basket of onion rings", "Starters", "basket of onion rings", 39, "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_900/https://lifeloveandgoodfood.com/wp-content/uploads/2015/06/onion-rings1.jpg");
                dish firstDish_ChickenFingers = new dish("Chicken fingers", "basket of Chicken fingers", "Starters", "basket of Chicken fingers", 48, "https://upload.wikimedia.org/wikipedia/commons/2/21/Crispy_Chicken_Strips_-_FotoosVanRobin.jpg");

                // get main-course
                dish mainCourse_Burger = new dish("Burger", "tasty burger", "MainCourse", "asd", 3, "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2017/5/10/0/FNM_060117-Smashburger-Style-Burgers-Recipe_s4x3.jpg.rend.hgtvcom.616.462.suffix/1494459418304.jpeg");
                dish mainCourse_ChickenFillet = new dish("Chicken fillet", "2 pieces with side-dish", "MainCourse", "2 pices of chicken", 62, "https://i.ndtvimg.com/i/2017-01/chicken-fillet-620x350_620x350_61485536532.jpg");
                dish mainCourse_FishNChips = new dish("Fish n chips", "fish strips on fries", "MainCourse", "fish strips on fries busket", 59, "https://media-cdn.tripadvisor.com/media/photo-p/13/7f/35/57/amy-s-fish-chips.jpg");
                dish mainCourse_HalleluiaChicken = new dish("Halleluia chicken", "shwarma with torrtillas", "MainCourse", "shwarma with torrtillas", 68, "https://sifu.unileversolutions.com/image/en-EG/recipe-topvisual/2/1260-709/chicken-shawarma-50256669.jpg");
                dish mainCourse_ChickenFahitas = new dish("Chicken fahitas", "chicken and veg inside tortillas", "MainCourse", "chicken and veg inside torttillas", 89, "https://carlsbadcravings.com/wp-content/uploads/2016/08/Chicken-Fajitas-2-650x975.jpg");
                dish mainCourse_VeggieFahitas = new dish("Veggie fahitas", "veg burger inside tortillas", "MainCourse", "veg burger inside tortillas", 89, "https://www.onelovelylife.com/wp-content/uploads/2017/07/fajitas1-SM.jpg");

                // get pizza
                dish pizza_Margarita = new dish("Pizza Margarita", "our homade pizza margarita", "Pizzas", "oven made fresh pizza", 39, "https://media-cdn.tripadvisor.com/media/photo-s/0e/9c/ab/14/pizza-margherita-con.jpg");
                dish pizza_Pepperoni = new dish("Pizza Pepperoni", "our homade pizza margarita with pepperoni", "Pizzas", "oven made fresh pizza with pepperoni", 49, "https://images-gmi-pmc.edge-generalmills.com/f4c0a86f-b080-45cd-a8a7-06b63cdb4671.jpg");
                dish pizza_MeatLovers = new dish("Pizza Meat Lovers", "amazing pizza for real meat lovers", "Pizzas", "cheese pizza with bacon, chicken, sausege and pepperoni", 69, "https://www.sodicgarden.com/wp-content/uploads/2018/07/MEt-Pizza.jpg");
                dish pizza_Buffalo = new dish("Buffalo Pizza", "pizza with blue cheese and hot fried chicken", "Pizzas", "pizza with blue cheese, hot fried chicken and oregano", 65, "https://foxeslovelemons.com/wp-content/uploads/2017/06/Buffalo-Shrimp-Pizza-720x540.jpg");
                dish pizza_Mexican = new dish("Mexican Pizza", "pizza with cooked veggies", "Pizzas", "our pizza with cooked onion and peppers ", 49, "https://keeprecipes.com/sites/keeprecipes/files/imagecache/recipe_large/16065_1357397078_0.jpg");

                // get salad
                dish salad_Mexican = new dish("Mexican salad", "our hot mexican salad", "Salats", "fresh lettece with tomatos, cucumber, onions and fried veggies", 49, "http://i.recipes-plus.com/styles/fp_detail/public/recipe/2016/04/hot-sweet-sour-green-papaya-salad.jpg");
                dish salad_MikesPlace = new dish("Mikes Place Salad", "salad 8 colors", "Salats", "salad with lots of veggies", 42, "https://i2.wp.com/aspicyperspective.com/wp-content/uploads/2018/07/Chopped-Israeli-Salad-with-Lemon-Vinaigrette-12.jpg");
                dish salad_Buffalo = new dish("Buffalo Salad", "our hot american salad", "Salats", "leaves salad with hot fried chicken", 62, "https://www.anduzzis.com/wp-content/uploads/buffalo-chicken-salad-1.jpg");
                dish salad_Ranch = new dish("Ranch Salad", "fati salad", "Salats", "leaves salad with chicken, bacon and cheese", 69, "https://www.gimmesomeoven.com/wp-content/uploads/2016/07/Kale-Salad-with-Bacon-and-Blue-Cheese-3.jpg");

                // get sandwiches
                dish burger_burger = new dish("Mikes Place Burger", "classic 200g burger", "Sandwiches", "classic burger serve with veggies on the side", 58, "https://d9hyo6bif16lx.cloudfront.net/live/img/production/detail/menu/lunch-dinner_burgers_all-american-burger.jpg");
                dish burger_cheeseAndBacon = new dish("cheese bacon burger", "chedder cheese and bacon on top of the burger", "Sandwiches", "amazing chedder cheese and bacon burger with veggies on the side", 68, "https://sifu.unileversolutions.com/image/en-AU/recipe-topvisual/2/1260-709/beef-burger-with-deep-fried-bacon-and-thousand-island-dressing-50247463.jpg");
                dish burger_bigMike = new dish("The BIG MIKE", "double burger with cheese and bacon", "Sandwiches", "double 200g burger with double of cheese and bacon", 89, "https://image.shutterstock.com/image-photo/tasty-double-burger-bacon-on-260nw-1053696920.jpg");
                dish burger_chickenSandwich = new dish("Chicken Sandwich", "classic 200g chicken burger", "Sandwiches", "chicken and veggies in a bun", 58, "http://life-in-the-lofthouse.com/wp-content/uploads/2014/07/Chic-Fil-A-copycat-sandwich.jpg");
                dish burger_veganBurger = new dish("veggie burger", "veggie burger", "Sandwiches", "veggie burger from soy", 58, "https://sweetsimplevegan.com/wp-content/uploads/2018/06/Vegan_High_Protein_Mushroom_Burgers_Sweet_Simple_Vegan_1-copy.jpg");
                dish burger_aliceTeaParty = new dish("Alice Tea Party", "burger with mushrooms, frie onions and cmehin", "Sandwiches", "200g burger served with fried mushrooms and onions and kmehin sause on top", 72, "http://woodysgrill.com/portal2/wp-content/uploads/2013/11/MushroomOnionBurger_web.jpg");
                dish burger_blt = new dish("BLT", "bacon strips burger with mayo", "Sandwiches", "3 strips of bacon with lettece, tomato and mayo", 58, "https://www.meatpoultry.com/ext/resources/MPImages/04-2019/041519/Sonic_Slide.jpg?1555442121");
                dish burger_muddies = new dish("Muddies sandwich", "fried chicken with hot sause in a bun", "Sandwiches", "fried chicken with hot sause in a bun", 72, "https://i.kinja-img.com/gawker-media/image/upload/s--rvazq1nQ--/c_scale,f_auto,fl_progressive,q_80,w_800/d01h32vyj51jhwjbaav1.jpg");
                dish burger_sloppyJoe = new dish("sloppy joe", "ground beef with bbq sause in a bun", "Sandwiches", "ground beef with bbq sause in a bun", 58, "https://www.dinneratthezoo.com/wp-content/uploads/2018/06/slow-cooker-sloppy-joes-4.jpg");
                
                // get kids
                dish kids_burger = new dish("Kiddy Burger", "200g burger and fries", "Kids", "special burger for kids", 46, "https://www.meatpoultry.com/ext/resources/MPImages/04-2019/041519/Sonic_Slide.jpg?1555442121");
                dish kids_pizza = new dish("Kiddy Pizza", "Pizza with topping", "Kids", "special pizza for kids", 58, "https://www.meatpoultry.com/ext/resources/MPImages/04-2019/041519/Sonic_Slide.jpg?1555442121");
                dish kids_chixFingers = new dish("Kiddy Chicken Fingers", "chicken fingers and fries", "Kids", "special fingers for kids", 58, "https://www.meatpoultry.com/ext/resources/MPImages/04-2019/041519/Sonic_Slide.jpg?1555442121");

                // push deserts
                myDishes.Add(desert_soufle);
                myDishes.Add(desert_cheeseCake);
                myDishes.Add(desert_troufles);
                myDishes.Add(desert_applePie);

                // push starters
                myDishes.Add(firstDish_Fries);
                myDishes.Add(firstDish_Nachos);
                myDishes.Add(firstDish_NachosSupreme);
                myDishes.Add(firstDish_NachosSupremeTexas);
                myDishes.Add(firstDish_Sausege);
                myDishes.Add(firstDish_MunchiesBusket);
                myDishes.Add(firstDish_MacNCheese);
                myDishes.Add(firstDish_Adamame);
                myDishes.Add(firstDish_BBQwings8);
                myDishes.Add(firstDish_BBQwings16);
                myDishes.Add(firstDish_Hotwings8);
                myDishes.Add(firstDish_HotWings16);
                myDishes.Add(firstDish_CheeseFries);
                myDishes.Add(firstDish_CheeseBaconFries);
                myDishes.Add(firstDish_OnionRings);
                myDishes.Add(firstDish_ChickenFingers);

                // push main-course
                myDishes.Add(mainCourse_Burger);
                myDishes.Add(mainCourse_ChickenFillet);
                myDishes.Add(mainCourse_FishNChips);
                myDishes.Add(mainCourse_HalleluiaChicken);
                myDishes.Add(mainCourse_ChickenFahitas);
                myDishes.Add(mainCourse_VeggieFahitas);

                // push pizza
                myDishes.Add(pizza_Margarita);
                myDishes.Add(pizza_Pepperoni);
                myDishes.Add(pizza_MeatLovers);
                myDishes.Add(pizza_Buffalo);
                myDishes.Add(pizza_Mexican);

                // push salad
                myDishes.Add(salad_Mexican);
                myDishes.Add(salad_MikesPlace);
                myDishes.Add(salad_Buffalo);
                myDishes.Add(salad_Ranch);

                // push burgers
                myDishes.Add(burger_burger);
                myDishes.Add(burger_cheeseAndBacon);
                myDishes.Add(burger_bigMike);
                myDishes.Add(burger_chickenSandwich);
                myDishes.Add(burger_veganBurger);
                myDishes.Add(burger_aliceTeaParty);
                myDishes.Add(burger_blt);
                myDishes.Add(burger_muddies);
                myDishes.Add(burger_sloppyJoe);

                //push kids
                myDishes.Add(kids_burger);
                myDishes.Add(kids_pizza);
                myDishes.Add(kids_chixFingers);
                return myDishes;
            }
        [HttpGet("drinks/{section}")]
        public ActionResult<drink> GetDrinksBySection(string section)
        {
            List<drink> allMenu = getAllDrinks();
            var filteredMenu = from drink a in allMenu
                               where a.section == section
                               select a;
            return Ok(filteredMenu);
        }

        [HttpGet("drinks/getSections")]
        public ActionResult<drink> GetDrinksSections()
        {
            string[] drinksOptions = new string[] {
                "beer", "whiskey", "vodka", "taquilla", "rum", "gin",
                "pitcher", "wine", "soft", "juice", "bottle","vermouth",
                "shots", "non-alcoholic", "liquer", "cocktails"};

            return Ok(drinksOptions);
        }
        // DONE: beer, whiskey, vodka, taquilla, rum, gin, pitcher, wine, soft, juice, bottle, vermouth, shots, non-alcoholic, liquers, cocktails      
        // LEFT: 
        private List<drink> getAllDrinks()
        {
            List<drink> myDrinks = new List<drink>();

            //get beer
            drink beer_goldstar= new drink("Goldstar", "pint 480 ml", "beer", "15 / 28", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_unflt = new drink("Goldstar unfiltered", "pint 480 ml", "beer", "15 / 28", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_macabbi = new drink("Macabbi", "pint 480 ml", "beer", "13 / 23", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_lagunitas = new drink("Lagunitas", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_dalirium= new drink("Dalirium", "glass 330ml", "beer", "35", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_carlsberg = new drink("Carlsberg", "pint 480 ml", "beer", "15 / 28", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_hoegardden = new drink("Hoegardden", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_weinVitus = new drink("Weinstephen Vitus", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_stella = new drink("Stella", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_guinness = new drink("Guinness", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_mpLager = new drink("Mikes Place Lager", "pint 480 ml", "beer", "14 / 26", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");
            drink beer_bluemoon= new drink("Bluemoon", "pint 480 ml", "beer", "18 / 34", "https://www.displayfakefoods.com/store/pc/catalog/2458-lg.jpg");

            //get whiskey
            drink whiskey_jimbeam = new drink("Jim Beam", "S/D", "whiskey", "16 / 32", "https://images-na.ssl-images-amazon.com/images/I/8160PPJeERL._SX385_.jpg");
            drink whiskey_bushmills = new drink("Bushmills", "S/D", "whiskey", "18 / 36", "https://images-na.ssl-images-amazon.com/images/I/51UU986ficL._SX679_.jpg");
            drink whiskey_jameson = new drink("Jameson", "S/D", "whiskey", "20 / 40", "https://images.freshop.com/00080432500118/fd1f8a8b01c366351639bb8f01d1f5e0_medium.png");
            drink whiskey_redLabel = new drink("Jhonnie walker red", "S/D", "whiskey", "20 / 40", "http://www.coreasdistribution.com/wp-content/uploads/johnny_walker_red.jpg");
            drink whiskey_jimbeamBlack = new drink("Jim Beam Black", "S/D", "whiskey", "22 / 42", "https://images.freshop.com/00080686034209/db88150f7bd5501d7d7fe0488fd978a1_medium.png");
            drink whiskey_jackDaniels = new drink("Jack Daniels", "S/D", "whiskey", "24 / 48", "https://www.gerrys.uk.com/content/images/thumbs/0000493_jack-daniels-70cl_256.png");
            drink whiskey_blackLabel = new drink("Jhonnie Walker Black", "S/D", "whiskey", "25 / 50", "https://www.celticwhiskeyshop.com/image/data/Scottish%20Whiskey/Johnnie-Walker-Black-Label.jpg");
            drink whiskey_blackbush = new drink("Black Bush", "S/D", "whiskey", "25 / 50", "https://images-na.ssl-images-amazon.com/images/I/71X3LvA9dTL._SY445_.jpg");
            drink whiskey_makersMark = new drink("Makers Mark", "S/D", "whiskey", "26 / 52", "https://images.freshop.com/00085246139431/baad413c5ce2e8b0b474e79620e64bf9_medium.png");
            drink whiskey_glen12 = new drink("Glenfidich 12", "S/D", "whiskey", "29 / 58", "http://d1lqpgkqcok0l.cloudfront.net/medias/sys_master/he2/h8d/8810694541342.jpg?buildNumber=762b487bb5b6d5161c1905bc66e5165f8d8a52ae");
            drink whiskey_glen15 = new drink("Glenfidich 15", "S/D", "whiskey", "35 / 70", "https://bevvyco.s3.amazonaws.com/img/drinks/uy/osuy/af8411e8a16f3824b8dce4a28f46a72b-md.jpg");
            drink whiskey_jentelmanJack = new drink("Jentelman Jack", "S/D", "whiskey", "35 / 70", "https://media.takealot.com/covers_tsins/43469335/082184029336-1-pdpxl.jpeg");

            //get vodka
            drink vodka_stoli = new drink("Stoli", "S/D", "vodka", "15 / 30", "https://img.thewhiskyexchange.com/900/vodka_sto5.jpg");
            drink vodka_stoliFlavour = new drink("Stoli with flavours", "S/D", "vodka", "18 / 36", "https://specsonline.com/wp-content/uploads/2018/09/081175102008.jpg");
            drink vodka_ketelOne = new drink("Ketel One", "S/D", "vodka", "22 / 44", "http://www.coreasdistribution.com/wp-content/uploads/Ketel_one_vodka.jpg");
            drink vodka_greyGoose = new drink("Grey Goose", "S/D", "vodka", "25 / 50", "https://images.freshop.com/00080480280000/d74995ce4eeca778c0b1e6ec123bfb30_medium.png");

            //get taqilla
            drink taqilla_cuervoGold = new drink("Cuervo Gold", "S/D", "taquilla", "18 / 36", "https://bevvyco.s3.amazonaws.com/img/drinks/fy/zefy/645a536bc7804edc3dbc06b4a0755ef6-md.jpg");
            drink taqilla_cuervoSilver = new drink("Cuervo Silver", "S/D", "taquilla", "20 / 40", "https://www.gerrys.uk.com/content/images/thumbs/0001114_jose-cuervo-silver-70cl_256.jpeg");
            drink taqilla_patron = new drink("Patron Silver", "S/D", "taquilla", "25 / 50", "https://images.freshop.com/00721733000944/e8a40a4c540336c25452e6fc66615653_medium.png");

            //get rum
            drink rum_captainMorgan = new drink("Captain Morgan Black", "S/D", "rum", "18 / 36", "https://images.freshop.com/00082000741992/f6145578c3fbe4639979b23ad68216b2_medium.png");
            drink rum_captainMorganSpiced = new drink("Captain Morgan Spiced", "S/D", "rum", "18 / 36", "https://www.gerrys.uk.com/content/images/thumbs/0001302_morgans-spiced-70cl_256.jpeg");
            drink rum_bacardi = new drink("Bacardi", "S/D", "rum", "20 / 40", "https://images.freshop.com/00080480015404/16a62d638ecbedf65e388697ec98ef01_medium.png");

            //get gin
            drink gin_gordons = new drink("Gordons", "S/D", "gin", "18 / 36", "https://bevvyco.s3.amazonaws.com/img/drinks/uy/piuy/4e71fa6fcad73512edaf866ec785cb6b-md.jpg");
            drink gin_bombay = new drink("Bombay", "S/D", "gin", "24 / 48", "https://www.gerrys.uk.com/content/images/thumbs/0000233_bombay-sapphire-70cl_256.png");

            //get liquer  -  upload photos from here.
            drink liquer_arak = new drink("Arak", "S/D", "liquer", "15 / 30", "https://www.thewhiskyworld.com/images/elite-arak-p2257-6310_image.jpg");
            drink liquer_fidg = new drink("Fidg", "S/D", "liquer", "15 / 30", "https://thumbnail.image.rakuten.co.jp/ran/img/3001/0004/004/752/252/492/30010004004752252492_1.jpg?_ex=128x128");
            drink liquer_jager = new drink("Jagermaister", "S/D", "liquer", "18 / 36", "https://static.turbosquid.com/Preview/2019/05/29__18_30_55/Sig_Image0057.jpg3C1835B1-6F6C-4B29-B9A2-564622715AD9Default.jpg");
            drink liquer_sambuca = new drink("Sambuca", "S/D", "liquer", "18 / 36", "https://www.gerrys.uk.com/content/images/thumbs/0002737_luxardo-sambuca-5cl_256.jpeg");
            drink liquer_ouzo = new drink("Ouzo", "S/D", "liquer", "18 / 36", "https://www.ab.gr/medias/sys_master/h8f/h00/8893392781342.jpg");
            drink liquer_southern = new drink("Southern Comfort", "S/D", "liquer", "20 / 40", "https://bevvyco.s3.amazonaws.com/img/drinks/gy/argy/fa3898311bc3a578313793ccca200609-md.jpg");
            drink liquer_irishCream = new drink("Irish Cream", "S/D", "liquer", "20 / 40", "https://i0.wp.com/www.drinkhacker.com/wp-content/uploads/2017/04/Baileys-Original-Irish-Cream.jpg?ssl=1");
            drink liquer_kaluah = new drink("Kaluah", "S/D", "liquer", "20 / 40", "https://upload.wikimedia.org/wikipedia/commons/3/37/Kahl%C3%BAa_700ml_imported_glass_bottle.jpg");
            drink liquer_midori = new drink("Midori", "S/D", "liquer", "20 / 40", "https://cdn11.bigcommerce.com/s-b0811/images/stencil/original/products/2287/6110/midori__52558.1438317167.JPG?c=2&imbypass=on");
            drink liquer_malibu = new drink("Malibu", "S/D", "liquer", "20 / 40", "https://www.dutyfree.co.il/media/catalog/product/cache/3/image/9df78eab33525d08d6e5fb8d27136e95/1/2/12131__12131.jpg");
            drink liquer_absinth = new drink("Absinth", "S/D", "liquer", "25 / 50", "https://www.licorea.com/images/magictoolbox_cache/feabb61ae2a71c1844359f7cbe8b5d82/9/7/97/original/232139930/absenta_reythor_70-_cl.jpg");
            drink liquer_cointreau = new drink("Cointreau", "S/D", "liquer", "25 / 50", "https://products1.imgix.drizly.com/ci-cointreau-2e73a93933df7dec.jpeg?auto=format%2Ccompress&fm=jpeg&q=20");
            drink liquer_drambuie = new drink("Drambuie", "S/D", "liquer", "27 / 54", "https://upload.wikimedia.org/wikipedia/commons/3/39/New_drambuie_bottle.jpg");
            drink liquer_hennessy = new drink("Hennessy", "S/D", "liquer", "27 / 54", "https://d3r6kbofdnmd8.cloudfront.net/media/catalog/product/cache/image/1536x/a4e40ebdc3e371adff845072e1c73f37/1/8/18291_Hennessy-VS-07L-40-Vol_4.jpg");

            //get wine
            drink wine_white_gevurtz = new drink("Gevurtz", "sweet white wine", "wine", "36 / 122", "https://www.slowwineco.com.au/S3/withwine-webstore-prod/Wine/SKBvY0a3XUGsOUDaJBZW6g.jpg?h=256&autorotate=true");
            drink wine_white_savignonBlanc = new drink("Savingnon Blanc", "half dry white wine", "wine", "36 / 122", "https://seewines.eu/media/catalog/product/cache/5/small_image/350x465/9df78eab33525d08d6e5fb8d27136e95/b/i/bialo_vino_sauvignon_blanc_barrel_fermented_maryan_2015_750ml.jpeg");
            drink wine_red_cabarnetSyra = new drink("Cabarnet Syra", "red wine", "wine", "36 / 122", "https://www.kosherwine.com/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/g/o/gogklfd90nme5hdylmfo.jpg");
            drink wine_red_shiraz= new drink("Shiraz", "red wine", "wine", "36 / 122", "https://images.ctfassets.net/6jpeaipefazr/1mkwCsJcGI2wk6CiAQKUKk/5dee55d669087b0a58f52801f5057e45/andrew-peace-shiraz-769432.png");
            drink wine_bubble_lambrusco = new drink("Lambrusco", "bottle of red Lambrusco", "wine", "122", "https://shop.r10s.jp/budoukan/cabinet/img/179385.jpg");
            drink wine_bubble_cava = new drink("Cava", "Sparkling cava", "wine", "36 / 122", "https://www.tanners-wines.co.uk/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/f/i/fi001.jpg");
            drink wine_bubble_rose = new drink("Cava Rose", "Sparking cava rose", "wine", "36 / 122", "https://cdn1.wine-searcher.net/images/labels/19/84/10651984.jpg");

            //get Pitcher
            drink pitcher_goldstar = new drink("Pitcher Goldstar", "1.7L", "pitcher", "79", "https://www.kegworks.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/e/beer-pitcher-go-b_1.jpg");
            drink pitcher_unflt = new drink("Pitcher Goldstar Unfiltred", "1.7L", "pitcher", "81", "https://www.kegworks.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/e/beer-pitcher-go-b_1.jpg");
            drink pitcher_mpLager = new drink("Pitcher M.P Lager", "1.7L", "pitcher", "79", "https://www.kegworks.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/e/beer-pitcher-go-b_1.jpg");
            drink pitcher_macabbi = new drink("Pitcher Macabbi", "1.7L", "pitcher", "72", "https://www.kegworks.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/e/beer-pitcher-go-b_1.jpg");

            //get bottle
            drink bottle_goldstar = new drink("Bottle of Goldstar", "500ml", "bottle", "25", "https://www.newyorkbeverage.com/wp-content/uploads/2017/09/goldstar-beer.jpg");
            drink bottle_carlsberg = new drink("Bottle of Carlsberg", "500ml", "bottle", "26", "https://cheers.com.np/uploads/products/745865535163692567535253899763575165634049734.png");
            drink bottle_tuborg = new drink("Bottle of Tuborg", "500ml", "bottle", "26", "https://i.pinimg.com/originals/69/a1/a6/69a1a643745b134afaadcb3e22a0e01e.jpg");
            drink bottle_corona = new drink("Bottle of Corona", "330ml", "bottle", "26", "https://images-na.ssl-images-amazon.com/images/I/51npRN-UrvL._SX522_.jpg");
            drink bottle_heinken = new drink("Bottle of Heinken", "330ml", "bottle", "29", "https://products1.imgix.drizly.com/ci-heineken-lager-6ea7dedfaaced647.jpeg?auto=format%2Ccompress&fm=jpeg&q=20");
            drink bottle_leffeBrune = new drink("Bottle of Leffe Brune", "330ml", "bottle", "30", "https://cdn.beeradvocate.com/im/beers/1862.jpg");
            drink bottle_strongbow = new drink("Bottle of Strongbow", "330ml", "bottle", "26", "https://products2.imgix.drizly.com/ci-strongbow-gold-apple-f54e949143c15d37.jpeg?auto=format%2Ccompress&fm=jpeg&q=20");
            drink bottle_breezer = new drink("Bottle of Breezer Watermelon", "330ml", "bottle", "29", "http://www.eliasi.co.il/ProductsImages/I542657_2412019143718.jpg");
            drink bottle_malca = new drink("Bottle of Malca", "330ml", "bottle", "32", "https://www.hagaban.co.il/wp-content/uploads/2018/10/%D7%9E%D7%9C%D7%9B%D7%94-%D7%91%D7%94%D7%99%D7%A8.jpg");

            //get soft
            drink soft_cola = new drink("Bottle of Coke", "330ml", "soft", "14", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/15-09-26-RalfR-WLC-0098.jpg/170px-15-09-26-RalfR-WLC-0098.jpg");
            drink soft_colaZero = new drink("Bottle of Coke Zero", "330ml", "soft", "14", "https://m.pricez.co.il/ProductPictures/7290008909884.jpg");
            drink soft_dietCola = new drink("Bottle of Diet Coke", "330ml", "soft", "14", "http://www.guyoffice.co.il/ProductsImages/s250/K298623.png");
            drink soft_fuzeT = new drink("Bottle of Fuze T", "330ml", "soft", "14", "https://www.school-market.co.il/src.ashx?p=2&f=2203x636257160553472288_L.jpg&w=300&h=300&t=1");
            drink soft_7up = new drink("Bottle of 7up", "330ml", "bottle", "14", "https://files.mishloha.co.il/files/menu_food_pic/FIL_268971_636687100777090875.jpg");
            drink soft_diet7up = new drink("Bottle of Diet 7up", "330ml", "soft", "14", "https://files.mishloha.co.il/files/menu_food_pic/thumbnail/FIL_268972_636687101220773636.jpg");
            drink soft_beer = new drink("Bottle of black beer", "330ml", "soft", "14", "http://misterburger.co.il/wp-content/uploads/2015/12/%D7%94%D7%95%D7%A8%D7%93.jpg");
            drink soft_gingerAle = new drink("Bottle of Ginger Ale", "330ml", "soft", "14", "https://blend.co.il/wp-content/uploads/2018/12/Tempo_images-adjust4.jpg");
            drink soft_mineral = new drink("Bottle of Mineral water", "330ml", "soft", "10", "https://cashcow-cdn.azureedge.net/images/c1c1298d-a8b4-4ae8-b321-32215e3f9119.jpg");
            drink soft_soda = new drink("Bottle of Soda", "330ml", "soft", "12", "https://files-ptdpritol.netdna-ssl.com/system/photos/2897260/large/70e282ab567c1545f186f9560fdd3d55.jpg");
            drink soft_tonic = new drink("Bottle of Tonic", "330ml", "soft", "14", "https://m.pricez.co.il/ProductPictures/7290008464321.jpg");
            drink soft_blu = new drink("Energy drink Blu", "330ml", "soft", "14", "https://files-ptdpritol.netdna-ssl.com/system/photos/3432560/show/d4d3dc2e50dd43b8f6b07d8eab0400c2.jpg");
            drink soft_redBull = new drink("Energy drink RedBull", "330ml", "soft", "25", "https://www.volgshop.ch/wp-content/uploads/2015/04/Red_Bull.jpg");

            //get juice
            drink juice_orange = new drink("Orange Juice", "S/L", "juice", "9 / 15", "https://www.thenational.ae/image/policy:1.884956:1563261659/image/jpeg.jpg?f=16x9&w=1200&$p$f$w=dfa40e8");
            drink juice_lemonade = new drink("Lemonade Juice", "S/L", "juice", "9 / 15", "https://previews.123rf.com/images/photomaru/photomaru1212/photomaru121200003/16887957-glass-of-lemonade-or-lemon-juice-isolated-on-white.jpg");
            drink juice_grapefruit = new drink("Red Grapefruit Juice", "S/L", "juice", "9 / 15", "https://images.wisegeek.com/glass-of-grapefruit-juice.jpg");
            drink juice_apple = new drink("Apple Juice", "S/L", "juice", "9 / 15", "https://st2.depositphotos.com/1177973/7550/i/950/depositphotos_75508049-stock-photo-glass-of-apple-juice-with.jpg");
            drink juice_cranberry = new drink("Cranberry Juice", "S/L", "juice", "9 / 15", "https://previews.123rf.com/images/galamik/galamik1203/galamik120300046/12758725-glass-of-cranberry-juice-on-a-white-background.jpg");
            drink juice_pineapple = new drink("Pineapple Juice", "S/L", "juice", "9 / 15", "https://previews.123rf.com/images/karandaev/karandaev1204/karandaev120400003/13202604-pineapple-juice-in-a-glass-isolated-on-white-background.jpg");

            //get vermouth
            drink vermouth_campari = new drink("Campari", "S/D", "vermouth", "18 / 36", "https://www.camparigroup.com/sites/default/files/brand/campari_1.png");
            drink vermouth_bianco = new drink("Martini Bianco", "D", "vermouth", "20", "https://img.thewhiskyexchange.com/900/vermo_mar66.jpg");
            drink vermouth_rosso = new drink("Martini Rosso", "D", "vermouth", "20", "https://manila-wine.com/media/catalog/product/cache/1/image/700x700/9df78eab33525d08d6e5fb8d27136e95/m/a/martini-rosso.jpg");
            drink vermouth_extraDry = new drink("Martini Extra Dry", "D", "vermouth", "20", "https://www.31dover.com/media/image/b6/9a/71/31dover-martini_extra_dry-shadow320x1000_1__1.jpg");

            //get non-alcoholic
            drink nonAlcoholic_heineken0 = new drink("Heinken 0.0", "330ml", "non-alcoholic", "26", "https://images-na.ssl-images-amazon.com/images/I/41tfYlRfZiL._SY450_.jpg");
            drink nonAlcoholic_luckyVirgin = new drink("Lucky Virgin", "Non-alcoholic Cocktail", "non-alcoholic", "25", "https://static.vinepair.com/wp-content/uploads/2017/10/strawberry-card.jpg");

            //get shots
            drink shots_babyGuinness = new drink("Baby Guinness", "Kaluah, Bailyes, Jameson", "shots", "25", "https://cocktails365.files.wordpress.com/2010/09/img_0043.jpg");
            drink shots_brainDamage = new drink("Brain Damage", "Peach liquer, beilyes, grenadin", "shots", "25", "https://d1alt1wkdk73qo.cloudfront.net/images/guide/1a1ef27166ba4c678f7e7a32df007567/478x640_ac.jpg");
            drink shots_thinRedLine = new drink("Thin Red Line", "Sambuca, Tabascco, Cuervo", "shots", "25", "https://i.pinimg.com/originals/eb/7d/2f/eb7d2f10296646cc8c7da6a327e3aaaf.jpg");
            drink shots_b52         = new drink("B52", "Kaluah, Bailyes, Controue", "shots", "29 / 50", "https://mixthatdrink.com/wp-content/uploads/2009/03/b52-shot-735x1103.jpg");
            drink shots_kamikaze = new drink("Kamikaze", "Stoly, Tripple Sec, Sour", "shots", "29 / 50", "https://cdn.diffords.com/contrib/stock-images/2016/12/43/201698803ccfcd2df237877ff41c735d9be4.jpg");
            drink shots_irishCarBomb = new drink("Irish Car Bomb", "Guinness, Jameson, Irish Cream", "shots", "45 / 80", "https://cdn.liquor.com/wp-content/uploads/2019/07/12110253/irish-car-bomb-720x720-recipe.jpg");
            drink shots_jagerBomb = new drink("Jager Bomb", "Blu, Jeger", "shots", "29 / 50", "https://thefndc.com/wp-content/uploads/2011/09/jagerbomb-main.jpg");

            //get cocktails
            drink cocktail_chaley = new drink("Charley", "vodka, peach liquer, coconut liquer, sour, pineapple juice and grenadin", "cocktails", "42", "https://images.cocktailflow.com/v1/cocktail/w_300,h_540/cocktail_pink_rum-1.png");
            drink cocktail_berrySour = new drink("Berry Sour", "berry stoly vodka, sour, berrys", "cocktails", "45", "http://1.bp.blogspot.com/-s-w0F1hR8BI/VU_NrVu8eVI/AAAAAAAAGvE/uTphkOvPttA/s1600/Honey%2Bberry%2Bsour.jpg");
            drink cocktail_longIsland = new drink("Long Island Iced Tea", "vodka, rum, jin, taquilla, tripple sec, lemon juice and coke", "cocktails", "45", "https://i.ytimg.com/vi/cUZTStHFePw/maxresdefault.jpg");
            drink cocktail_margarita = new drink("Margarita", "cuervo, tripple sec and lime", "cocktails", "45", "https://www.thecocktailproject.com/sites/default/files/classicmargarita_beauty-1175-Edit_thumbnail.jpg");
            drink cocktail_sexOnTheBeach = new drink("Sex On The Beach", "vodka, peach liquer, orange juice and cranberry", "cocktails", "42", "https://cdn.liquor.com/wp-content/uploads/2015/10/20001944/il_fullxfull.322976552.jpg");
            drink cocktail_midoriSour = new drink("Midori Sour", "Midoru and Sour", "cocktails", "42", "https://i.pinimg.com/originals/09/d2/e4/09d2e47ce84da4ccedcda734135a5741.jpg");
            drink cocktail_mohito = new drink("Mohito", "captain morgan spiced with sour and soda", "cocktails", "42", "https://media-cdn.tripadvisor.com/media/photo-s/0c/a2/61/e5/mohito.jpg");
            drink cocktail_maiTai = new drink("Mai Tai", "rum, ammarto, tripple sec, sour, pineapple juice and grenadin", "cocktails", "42", "https://cdn.liquor.com/wp-content/uploads/2017/08/31104342/IMG_0007-768x1024.jpg");


            //push beer
            myDrinks.Add(beer_goldstar);
            myDrinks.Add(beer_unflt);
            myDrinks.Add(beer_macabbi);
            myDrinks.Add(beer_lagunitas);
            myDrinks.Add(beer_dalirium);
            myDrinks.Add(beer_carlsberg);
            myDrinks.Add(beer_hoegardden);
            myDrinks.Add(beer_weinVitus);
            myDrinks.Add(beer_stella);
            myDrinks.Add(beer_guinness);
            myDrinks.Add(beer_mpLager);
            myDrinks.Add(beer_bluemoon);

            //push whiskey
            myDrinks.Add(whiskey_jimbeam);
            myDrinks.Add(whiskey_bushmills);
            myDrinks.Add(whiskey_jameson);
            myDrinks.Add(whiskey_redLabel);
            myDrinks.Add(whiskey_jimbeamBlack);
            myDrinks.Add(whiskey_jackDaniels);
            myDrinks.Add(whiskey_blackLabel);
            myDrinks.Add(whiskey_blackbush);
            myDrinks.Add(whiskey_makersMark);
            myDrinks.Add(whiskey_glen12);
            myDrinks.Add(whiskey_glen15);
            myDrinks.Add(whiskey_jentelmanJack);

            //push vodka
            myDrinks.Add(vodka_stoli);
            myDrinks.Add(vodka_stoliFlavour);
            myDrinks.Add(vodka_ketelOne);
            myDrinks.Add(vodka_greyGoose);

            //push taquilla
            myDrinks.Add(taqilla_cuervoGold);
            myDrinks.Add(taqilla_cuervoSilver);
            myDrinks.Add(taqilla_patron);

            //push rum
            myDrinks.Add(rum_captainMorgan);
            myDrinks.Add(rum_captainMorganSpiced);
            myDrinks.Add(rum_bacardi);

            //push gin
            myDrinks.Add(gin_gordons);
            myDrinks.Add(gin_bombay);

            //push liquer
            myDrinks.Add(liquer_arak);
            myDrinks.Add(liquer_fidg);
            myDrinks.Add(liquer_jager);
            myDrinks.Add(liquer_sambuca);
            myDrinks.Add(liquer_ouzo);
            myDrinks.Add(liquer_southern);
            myDrinks.Add(liquer_irishCream);
            myDrinks.Add(liquer_kaluah);
            myDrinks.Add(liquer_midori);
            myDrinks.Add(liquer_malibu);
            myDrinks.Add(liquer_absinth);
            myDrinks.Add(liquer_cointreau);
            myDrinks.Add(liquer_drambuie);
            myDrinks.Add(liquer_hennessy);

            //push wine
            myDrinks.Add(wine_white_gevurtz);
            myDrinks.Add(wine_white_savignonBlanc);
            myDrinks.Add(wine_red_cabarnetSyra);
            myDrinks.Add(wine_red_shiraz);
            myDrinks.Add(wine_bubble_lambrusco);
            myDrinks.Add(wine_bubble_cava);
            myDrinks.Add(wine_bubble_rose);

            //push pitcher
            myDrinks.Add(pitcher_goldstar);
            myDrinks.Add(pitcher_unflt);
            myDrinks.Add(pitcher_mpLager);
            myDrinks.Add(pitcher_macabbi);

            //push bottle
            myDrinks.Add(bottle_goldstar);
            myDrinks.Add(bottle_tuborg);
            myDrinks.Add(bottle_carlsberg);
            myDrinks.Add(bottle_corona);
            myDrinks.Add(bottle_heinken);
            myDrinks.Add(bottle_leffeBrune);
            myDrinks.Add(bottle_strongbow);
            myDrinks.Add(bottle_breezer);
            myDrinks.Add(bottle_malca);

            //push soft
            myDrinks.Add(soft_cola);
            myDrinks.Add(soft_colaZero);
            myDrinks.Add(soft_dietCola);
            myDrinks.Add(soft_fuzeT);
            myDrinks.Add(soft_7up);
            myDrinks.Add(soft_diet7up);
            myDrinks.Add(soft_beer);
            myDrinks.Add(soft_gingerAle);
            myDrinks.Add(soft_soda);
            myDrinks.Add(soft_mineral);
            myDrinks.Add(soft_tonic);
            myDrinks.Add(soft_blu);
            myDrinks.Add(soft_redBull);

            //push juice
            myDrinks.Add(juice_orange);
            myDrinks.Add(juice_lemonade);
            myDrinks.Add(juice_grapefruit);
            myDrinks.Add(juice_apple);
            myDrinks.Add(juice_cranberry);
            myDrinks.Add(juice_pineapple);

            //push vermouth
            myDrinks.Add(vermouth_campari);
            myDrinks.Add(vermouth_bianco);
            myDrinks.Add(vermouth_rosso);
            myDrinks.Add(vermouth_extraDry);

            //push non-alcoholic
            myDrinks.Add(nonAlcoholic_heineken0);
            myDrinks.Add(nonAlcoholic_luckyVirgin);

            //push shots
            myDrinks.Add(shots_babyGuinness);
            myDrinks.Add(shots_brainDamage);
            myDrinks.Add(shots_thinRedLine);
            myDrinks.Add(shots_kamikaze);
            myDrinks.Add(shots_b52);
            myDrinks.Add(shots_irishCarBomb);
            myDrinks.Add(shots_jagerBomb);

            //push cocktails
            myDrinks.Add(cocktail_chaley);
            myDrinks.Add(cocktail_berrySour);
            myDrinks.Add(cocktail_longIsland);
            myDrinks.Add(cocktail_margarita);
            myDrinks.Add(cocktail_sexOnTheBeach);
            myDrinks.Add(cocktail_midoriSour);
            myDrinks.Add(cocktail_mohito);
            myDrinks.Add(cocktail_maiTai);

            return myDrinks;
        }
    }
}
