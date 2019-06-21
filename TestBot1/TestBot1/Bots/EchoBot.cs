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
using System;

namespace TestBot1.Bots

{
    
    public class EchoBot : ActivityHandler
    {
        private static ITurnContext<IConversationUpdateActivity> _turnContext;
        private static CancellationToken _cancellationToken;
        public static int conta2 = 1;
        

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {

        int conta = 0;
            Dictionary<List<string>, string> str = new Dictionary<List<string>,string>();
            str.Add(new List<string> {"ciao","salve","hello","hi","hey"}, "Ciao, come posso aiutarti ?");
            str.Add(new List<string> {"dove si trova il beacon più vicino?", "dove si trova il beacon più vicino ?", "dove si trova il beacon più vicino", "dove è il beacon più vicino ?" }, "Il beacon più vicino si trova a .. ");
            str.Add(new List<string> {"cosa trovo più avanti?", "cosa trovo più avanti ?","cosa c'è più in avanti ?","cosa trovo più avanti" }, "Il percorso prosegue per altri N km in direzione X, sul percorso troverai N beacon e i seguenti punti di interesse : ...");
            str.Add(new List<string> {"quali sono le prossime tappe?", "quali sono le prossime tappe", "quali sono le prossime tappe ?", "quali tappe trovo più in avanti ?", "quali tappe trovo più in avanti?"}, "Le prossime tappe saranno: X ,\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"dove si trova la fontanella più vicina?", "dove si trova la fontanella più vicina ?", "dove si trova la fontanella più vicina","dove trovo la fontanella ?","dove c'è una fontanella ?" }, "Si trova tra X metri.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"dove posso bere ?", "dove posso bere?" , "dove posso bere","dove trovo l'acqua?" ,"dove trovo l'acqua ?","ho sete","dove posso trovare dell'acqua potabile ?","dove posso trovare dell'acqua potabile?","dove posso trovare dell'acqua potabile"}, "C'è una fontanella di acqua tra X metri. \n Premi sul link seguente per vedere tutti i punti di ristoro. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf ");
            str.Add(new List<string> {"dove posso mangiare?", "dove posso mangiare ?" , "dove posso mangiare","dove si mangia ?","ho fame","dove sono i ristoranti ?","dove sono i ristoranti?","ci sono ristoranti ?","dove trovo un ristorante ?","dove trovo un ristorante?" }, "A X metri si trova il ristorante piu vicino. Altrimenti guarda tra questi : ... \n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"qual è la città più vicina?", "qual è la città più vicina ?", "qual è la città più vicina","la città più vicina?","la città più vicina ?","dove si trova la città più vicina?","dove si trova la città più vicina ?" }, "La città piu vicina è:'XXXX', e si trova a X km.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"quanti gradi ci sono?", "quanti gradi ci sono ?", "quanti gradi ci sono","quanti gradi ci saranno oggi?","quanti gradi ci saranno oggi","quanti gradi ci sranno oggi ?" }, "Per informazioni sul meteo premi sul seguente link :\n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> {"meteo","com'è il tempo?"}, "Per informazioni sul meteo clicca sul seguente link : \n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> {"domani piove?", "domani piove ?", "domani piove", "piove domani ?","piove domnani","piove domani?"}, "Per informazioni sul meteo premi sul seguente link: \n https://www.3bmeteo.com/meteo/varese#");
            str.Add(new List<string> {"dove mi trovo?","dove mi trovo ?","dove mi trovo","dove sono?","dove sono","dove sono ?"}, "Ti trovi al km X della via francisca.\n Premi sul link per vedere la mappa. \n https://siviaggia.files.wordpress.com/2019/02/mappa-2.pdf");
            str.Add(new List<string> {"che cos'è la via francisca ?", "che cos'è la via francisca?","storia della via francisca","via francisca" }, "Clicca sul link seguente per informarti : http://www.vareselandoftourism.com/via-francisca-del-lucomagno");
            str.Add(new List<string> {"quali sono le tappe principali?", "quali sono le tappe principali ?", "quali sono le tappe principali", "tappe principali?", "tappe principali ?" }, "Le tappe fondamentali del percorso sono..");
            str.Add(new List<string> {"uscita percorso","voglio uscire dalla via","dov'è l'uscita ?", "dov'è l'uscita?", "dov'è l'uscita","come faccio ad uscire ?", "come faccio ad uscire?","Uscita più vicina ?" }, "Le vie d'uscita sono indicate nella mappa, clicca sul link per visualizzare la mappa: \n https://www.3bmeteo.com/meteo/varese#");

            //FRASI DEMO VIDEO  
            str.Add(new List<string>{"dove sono i migliori punti panoramici?", "dove sono i migliori punti panoramici ?","punti panoramici vicini" }, "Nelle vicinanze puoi goderti la vista da X.\nPremi sul link che segue per vedere tutti i punti panoramici nel raggio di 5km.\n http://www.vareselandoftourism.com/via-francisca-del-lucomagno");
            str.Add(new List<string> {"dove si può dormire?", "dove si può dormire?", "dove si può dormire","ho sonno","voglio dormire"}, "Clicca sul link sueguente e troverai gli alberghi della zona.\n http://www.vareselandoftourism.com/via-francisca-del-lucomagno");
            str.Add(new List<string> {"in che condizioni è il percorso?", "in che condizioni è il percorso ?", "in che condizioni è il percorso" }, "Il percorso è percoribbile tranquillamente a piedi, al momento non ci sono segnalazioni di problemi riguardo allo stato del percorso");
            str.Add(new List<string> {"che attrezzature mi servono?", "che attrezzature mi servono ?", "che attrezzature mi servono" }, "Il mio consiglio che ti do è di indossare delle scarpe comode, ma soppratutto ricordati di portarti una borraccia per l'acqua e un kit di primo soccorso");








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

        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id == "user")
                {
                    _turnContext = turnContext;
                    _cancellationToken = cancellationToken;
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Ciao, sono Wainy, il tuo nuovo compagno di viaggio virtuale. Tu come ti chiami?"), cancellationToken);
                    conta2 = 2;
                }
            }
        }

        public async void beacon(string messaggio)
        {
            try
            {

                switch (int.Parse(messaggio))
                {
                    case 1:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Sei in prossimtà del Ponte Coperto di Pavia, prosegui per altri X metri o consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                    case 2:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Sei in prossimtà dell' Abbazia di Morimondo, prosegui per altri X metri o consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                    case 3:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Sei in prossimtà del Naviglio, prosegui per altri X metri o consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                    case 4:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Sei in prossimtà della Collegiata di Castiglione Olona, prosegui per altri X metri o consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                    case 5:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Sei in prossimtà del Sacro Monte di Varese, prosegui per altri X metri o consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                    default:
                        await _turnContext.SendActivityAsync(MessageFactory.Text("Consulta la mappa con il seguente link:\n http://francigena-international.org/wordpress/wp-content/uploads/2017/03/VF-Lukmanier.jpg"), _cancellationToken);
                        break;
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
