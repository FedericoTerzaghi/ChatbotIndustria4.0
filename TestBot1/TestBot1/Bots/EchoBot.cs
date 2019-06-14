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
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            int conta = 0;
            Dictionary<string, string> str = new Dictionary<string,string>();
            str.Add("Ciao", "Ciao, piacere sono wainy, come posso aiutarti ?");
            str.Add("Dove si trova il beacon più vicino?", "Il beacon più vicino si trova a .. ");
            str.Add("Cosa trovo più avanti?", "Il percorso prosegue per altri ...km in direzione tot, e ..km in direzione tot. sul percorso troverai tot beacon e i seguenti punti di interesse");
            str.Add("Quante tappe trovo sul mio percorso?", "Troverai altre n tappe");
            str.Add("Dove si trova la fontanella più vicina?", ".Si trova a tot ");
            str.Add("Dove posso bere?", "Tra tot metri trovi questo locale altrimenti una fontanella a tot");
            str.Add("Dove posso mangiare?", "A tot metri si trova il ristorante piu vicino altrimenti guarda tra questi!");
            str.Add("Qual è la città più vicina?", "La città piu vicina è tot a tot ");
            str.Add("Quanti gradi ci saranno oggi?", "Al momento la temperatura è di tot gradi ma nel pomeriggio sera sarà di");
            str.Add("Che tempo fa domani?", "Domani sarà piovoso altrimenti guarda il meteo a questo link : \n https://www.meteo.it/meteo/busto-arsizio-12026");
            str.Add("Domani piove?", "Domani sarà piovoso altrimenti guarda il meteo a questo link : \n https://www.meteo.it/meteo/busto-arsizio-12026");
            str.Add("Dove mi trovo?", "ti trovi al km tot della via francisca. intorno a te hai questi beacon e luoghi di interesse. la citta piu vicina è tot. vuoi informazioni piu dettagliate? vai ai seguenti link");
            str.Add("Quali luoghi di culto trovo nelle vicinanze?", "I luoghi di culto nelle vicinanze sono ... i più visitati invece sono.. ");
            str.Add("Qual è la strada più veloce per raggiungere..?", "//apro mappa");
            str.Add("Tra quante ore tramonta il sole?", "Il sole tramonta tra tot");
            str.Add("Chiama i soccorsi", "//avvio chiamata al 112");
            str.Add("Il ristorante aperto più vicino?", "Il ristorante aperto più vicino è il ... ma il sta facendo un'ottima offerta!");
            str.Add("La veduta più bella?", "punto di osservazione più bello del percorso si trova qui, il piu vicino a te invece ");
            str.Add("Raccontami un po di storia", "La via francigena..per approfondire guarda qui");
            str.Add("Quali sono le tappe principali?", "Le tappe fondamentali del percorso sono..");



            
            foreach (KeyValuePair<string, string> entry in str)
            {
                
                
                if (entry.Key.ToLower() == turnContext.Activity.Text.ToLower()) 
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
                await turnContext.SendActivityAsync(MessageFactory.Text($"E' un piacere conoscerti {turnContext.Activity.Text} ! \n Devi sapere che sono molto giovane e sto imparando velocemente...se non rispondo subitoadeguatamente non smettere di parlarmi, prova a riformulare la domanda!"), cancellationToken);
                conta2 = 0;
            }else if (conta2==1 && conta == 0)
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"Devi sapere che sono molto giovane e sto imparando velocemente...se non rispondo subitoadeguatamente non smettere di parlarmi, prova a riformulare la domanda!"), cancellationToken);
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
