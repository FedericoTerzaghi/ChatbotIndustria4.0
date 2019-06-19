// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.3.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections;

namespace TestBot1.Bots

{

    public class EchoBot : ActivityHandler
    {
        
        public static int conta2 = 1;


        //public  override async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        //{
        //    var activityType = turnContext.Activity.Type;
        //    var conversationReference = (ConversationReference)null;

        ////    if (activityType == ActivityTypes.Message || activityType == ActivityTypes.ConversationUpdate)
        ////    {
        ////        conversationReference = turnContext.Activity.GetConversationReference();

        ////        _logger.LogTrace("----- ProactiveBot - Get conversation reference - Activity type: {ActivityType} User: \"{User}\" - ConversationReference: {@ConversationReference}", activityType, conversationReference.User.Name, conversationReference);

        ////        if (conversationReference.User.Name != null)
        ////        {
        ////            _conversations.Save(conversationReference);
        ////        }
        ////    }

        ////    if (activityType == ActivityTypes.Message)
        ////    {
        ////        var text = turnContext.Activity.Text.Trim();

        ////        _logger.LogInformation("----- Receiving message activity - Text: {Text}", text);

        ////        var username = conversationReference.User.Name;

        //////...
        ////        else if (text.StartsWith("conversations", StringComparison.InvariantCultureIgnoreCase))
        ////        {
        ////            var conversations = string.Join("\n", _conversations.Select(c => $"- **{c.Key}**: {c.Value.ChannelId} ({c.Value.User.Id})"));

        ////            await turnContext.SendActivityAsync($"**CONVERSATIONS**\n{conversations}");
        ////        }
        ////        //...
        ////    }
        ////    else if (activityType == ActivityTypes.Event)
        ////    {
        ////        var name = turnContext.Activity.Name;
        ////        var value = turnContext.Activity.Value;

        ////        _logger.LogInformation("----- Receiving event activity - Name: {Name} ({Value})", name, value);

        ////        await turnContext.SendActivityAsync($"**{name}** event detected - Payload:  {value}");
        ////    }
        ////    else
        ////    {
        ////        await turnContext.SendActivityAsync($"**{turnContext.Activity.Type}** activity received");
        ////    }
        //}
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            int conta = 0;
            Dictionary<List<string>, string> str = new Dictionary<List<string>,string>();
            str.Add(new List<string> { "ciao","salve","hello","hi","hey"}, "Ciao, come posso aiutarti ?");
            str.Add(new List<string> { "dove si trova il beacon più vicino?", "dove si trova il beacon più vicino ?", "dove si trova il beacon più vicino", "dove è il beacon più vicino ?" }, "Il beacon più vicino si trova a .. ");
            str.Add(new List<string> { "cosa trovo più avanti?", "cosa trovo più avanti ?","cosa c'è più in avanti ?","cosa trovo più avanti" }, "Il percorso prosegue per altri N km in direzione X, sul percorso troverai N beacon e i seguenti punti di interesse : ...");
            str.Add(new List<string> { "quali sono le prossime tappe?", "quali sono le prossime tappe", "quali sono le prossime tappe ?", "quali tappe trovo più in avanti ?", "quali tappe trovo più in avanti?"}, "Le prossime tappe saranno: X ,\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> { "dove si trova la fontanella più vicina?", "dove si trova la fontanella più vicina ?", "dove si trova la fontanella più vicina","dove trovo la fontanella ?","dove c'è una fontanella ?" }, "Si trova tra X metri.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> { "dove posso bere ?", "dove posso bere?" , "dove posso bere","dove trovo l'acqua?" ,"dove trovo l'acqua ?","ho sete"}, "Tra X metri trovi questo locale:'XXXXX', altrimenti una fontanella a X metri.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf ");
            str.Add(new List<string> { "dove posso mangiare?", "dove posso mangiare ?" , "dove posso mangiare","dove si mangia ?","ho fame","dove sono i ristoranti ?","dove sono i ristoranti?","ci sono ristoranti ?","dove trovo un ristorante ?","dove trovo un ristorante?" }, "A X metri si trova il ristorante piu vicino. Altrimenti guarda tra questi : ... \n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> { "qual è la città più vicina?", "qual è la città più vicina ?", "qual è la città più vicina","la città più vicina?","la città più vicina ?","dove si trova la città più vicina?","dove si trova la città più vicina ?" }, "La città piu vicina è:'XXXX', e si trova a X km.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> { "quanti gradi ci sono?", "quanti gradi ci sono ?", "quanti gradi ci sono","quanti gradi ci saranno oggi?","quanti gradi ci saranno oggi","quanti gradi ci sranno oggi ?" }, "Per informazioni sul meteo premi sul seguente link :\n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> { "meteo","com'è il tempo?"}, "Per informazioni sul meteo clicca sul seguente link : \n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> { "domani piove?", "domani piove ?", "domani piove", "piove domani ?","piove domnani","piove domani?"}, "Per informazioni sul meteo premi sul seguente link: \n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> { "dove mi trovo?","dove mi trovo ?","dove mi trovo","dove sono?","dove sono","dove sono ?"}, "Ti trovi al km X della via francisca.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"che cos'è la via francisca ?", "che cos'è la via francisca?","storia della via francisca","via francisca" }, "Clicca sul link seguente per informarti : http://www.vareselandoftourism.com/via-francisca-del-lucomagno");
            str.Add(new List<string> { "quali sono le tappe principali?", "quali sono le tappe principali ?", "quali sono le tappe principali", "tappe principali?", "tappe principali ?" }, "Le tappe fondamentali del percorso sono..");
            str.Add(new List<string> { "uscita percorso","voglio uscire dalla via","dov'è l'uscita ?", "dov'è l'uscita?", "dov'è l'uscita","dome faccio ad uscire ?", "dome faccio ad uscire?","Uscita più vicina ?" }, "Le vie d'uscita sono indicate nella mappa, clicca sul link per visualizzare la mappa: \n https://www.3bmeteo.com/meteo/varese#");



            foreach (KeyValuePair<List<string>, string> entry in str)
            {
                
                
                if (entry.Key.Contains(turnContext.Activity.Text.ToLower())) 
                {
                   
                    conta = 1;
                    await turnContext.SendActivityAsync(MessageFactory.Text($"{entry.Value}"), cancellationToken);
                    conta2 = 1;
                }

            }
            if (conta2 == 0 && conta == 0)
            {
                conta2 = 1;
            }
            if (conta2 == 2)
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"E' un piacere conoscerti {turnContext.Activity.Text} ! \n Devi sapere che sono molto giovane e sto imparando, se non rispondo adeguatamente non smettere di parlarmi, prova a riformulare la domanda :)"), cancellationToken);
                conta2 = 0;
            }else if (conta2==1 && conta == 0)
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"Devi sapere che sono molto giovane e sto imparando, se non rispondo adeguatamente non smettere di parlarmi, prova a riformulare la domanda :)"), cancellationToken);
            }


                //if(turnContext.Activity.InputHint!=null)
            //{
            //    await turnContext.SendActivityAsync(MessageFactory.Text($"BotInutile: è inutile che mi scrivi non voglio parlare con te! "), cancellationToken);
            //}
            //await turnContext.SendActivityAsync(MessageFactory.Text($"Echo:{turnContext.Activity.Text}"), cancellationToken);


        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Ciao, sono Wainy, il tuo nuovo compagno di viaggio virtuale. Tu come ti chiami?"), cancellationToken);
                    conta2 = 2;
                }
            }
        }
    }
}
