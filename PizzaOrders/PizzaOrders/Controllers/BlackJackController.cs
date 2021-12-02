using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using PizzaOrders.Areas.BlackJack.Models;

namespace PizzaOrders.Areas.BlackJack.Controllers
{
    
    public class BlackJackController : Controller
    {
        private Random _random = new Random();
        
        public BlackJackController()
        {
            
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Game()
        {
            var model = new BlackJackModel();
            return View("Game",model);
        }
        
        [HttpPost]
        public IActionResult Game(BlackJackModel model)
        {
            PrepBlackJackModel(model);
            return View(model);
        }

        private void PrepBlackJackModel(BlackJackModel model)
        {
            if (model == null)
            {
                model = new BlackJackModel();
            }

            model.NumberOne = GetRandomNumber();
            model.NumberTwo = GetRandomNumber();

            if (model.NumberOne == 11 || model.NumberTwo == 11 && model.Result >= 21)
            {
                model.NumberOne = 1;
            }
            model.DealerNumberOne = GetRandomNumber();
            model.DealerNumberTwo = GetRandomNumber();
            GameWinner(model, model.Result, model.DealerResult);

        }

        private void GameWinner(BlackJackModel model, int numberOne, int numberTwo)
        {
            if (numberOne > 21 && numberTwo > 21)
            {
                model.Winner = "Bust";
            }
            else if(numberOne >21 && numberTwo <= 21)
            {
                model.Winner = "Dealer Wins";
            }
            else if(numberOne <= 21 && numberTwo > 21)
            {
                model.Winner = "Player Wins";
            }
            else if(numberOne > numberTwo)
            {
                model.Winner = "Player Wins";
            } 
            else if (numberOne < numberTwo)
            {
                model.Winner = "Dealer Wins";
            } 
            else if (numberOne == 21 )
            {
                model.Winner = "Player Wins";
            } 
            else if (numberTwo == 21 )
            {
                model.Winner = "Dealer Wins";
            }
            else
            {
                model.Winner = "Draw";
            }
        }
        private int GetRandomNumber()
        {
            return _random.Next(1, 21);;
        }
        
    }
}