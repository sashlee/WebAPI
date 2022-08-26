using Microsoft.AspNetCore.Mvc;
using MyDataBase.Entity;
using WebAPI.Models;

namespace WebAPI.Service
{
    public class CardRequestService
    {
        DatabaseCoreContext _context = new DatabaseCoreContext();
        public CardResponse CreateCardRequest(CardRequest um)
        {
            try
            {
                CardInfo  info = new CardInfo();
                info.Name = um.CardName;
                info.CardType = um.CardType;
                info.DateRequested = DateTime.Now;
                

                _context.CardInfos.Add(info);
                _context.SaveChanges();

                return new CardResponse() { TrackingId = info.Id, CardName = info.Name, CardType = info.CardType };

            }
            catch (Exception ex)
            {
                return new CardResponse();
            }
        }
    }
}
