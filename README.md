# SUT23_Individuellt_projekt
Detta är ett program som fungerar som en enklare bankomat.
Det finns fem lagrade användare med användarnam, pinkod, count (återgår till denna senare), samt två arrayer för kontonamn och kontosaldo.
När programmet startat körs först metoden "StoreUsers();" för att kalla på de lagrade användarna. 
Därefter körs programmet Login(); för att låta användaren logga in.

Login();
Login-metoden körs i en while-loop, där loopen frågar efter användarnamn och pin förutsatt att ingen redan är inloggad.
Metoden söker efter användarens användarnamn i en tidigare sparad lista som genererar alla användares information. 
Om användarnamnet ej hittas startar loopen om.
Förutsatt att användaren hittas fortsätter metoden att efterfråga pinkod.
Användaren får tre försök på sig att skriva in rätt pinkod  (här används count för den lagrade användaren för att räkna antalet felslag) , lyckas hen inte låses hen ut från programmet och kan inte logga in om hen inte startar om det. 
Metoden söker efter pinkoden som finns lagrad hos användaren. Om den hittas skickar Login användaren till Meny();-metoden.
Metoden returnerar även "LoggedIn" där användaren är lagrad.

Logout(ref Users LoggedIn)
Metoden läser in vilken användare som använder programmet.
Metoden skriver ut att användaren är utloggad och genom att trycka på enter återgår programmet till menyn.
Dessförinann loggar programmet ut användaren genom att referera till Login-metoden och sätta LoggedIn till null, dvs, ingen användare är längre inloggad.

Meny(Users LoggedIn);
Metoden läser in vilken användare som använder programmet.
I Meny-metoden får användaren 4 val, Se över konton, Överföringar, Ta ut pengar eller Logga ut. 
En try-catch har satts för att användaren inte ska kunna skriva in ett annat värde och krascha programmet. 
Användaren skickas sedan till den metod hen väljer genom en switch.

StoreUsers():
Här lagras information om de olika användarna.

[]UserLists(Users LoggedIn);
Här skapas en kombinerad array av användarnas konton och den summan som är på dem så att man kommer åt rätt saldo för rätt konto i andra metoder.
Denna returneras sedan som UserAccounts.

UserAccInfo(Users LoggedIn);
Metoden läser in vilken användare som använder programmet.
I metoden UserAccInfo(); skriver programme ut de konton som användaren har genom att använda en foreach-loop. 
Användaren kan sedan välja att återgå till menyn genom att trycka på enter.

Transfer(Users LoggedIn);
Metoden läser in vilken användare som använder programmet.
Metoden läser in arrayen från UsersList.
I metoden Transfer(); presenteras användaren för de konton hen har med användning av en for-loop. 
Metoden använder en while-loop för att ge användaren fler möjligheter att göra val.
Användaren får välja vilket konto som hen vill föra över pengar från.
Metoden sätter en int som korrelerar med användarens input som sedan används för att söka efter vilken plats i arrayen kontot finns. 
Användaren får sedan frågan om det är rätt konto, om det inte stämmer börjar loopen om.
Om det är det kontot användaren vill föra över från får användaren sedan frågan vilket konto hen vill överföra pengar från.
Metoden sätter en int som korrelerar med användarens input som sedan används för att söka efter vilken plats i arrayen kontot finns. 
Användaren får sedan frågan om det är rätt konto, om det inte stämmer börjar loopen om.
Användaren får skriva in vilket belopp hen vill ta ut, detta sätts som en double för att tillåta både kronor och ören.
En ny double sourceBalance skapas för kontot pengarna ska föras över från, där man splittar den kombinerade arrayen sourceAcc för att komma åt endast double-delen i arrayen.
Samma sak görs för targetBalance - dvs kontot pengarna ska överföras till.

Beloppet användaren skrivit in förs sedan över från LoggedIn.accountValue[sourceAccIndex] - dvs kontots double värde som är deklarerat i StoreUsers till LoggedIn.accountValue[targetAccIndex].
Användaren får meddelandet att överföringen lyckats och förs sedan till UserAccInfo där hen ser balensen för sina konton.
Finns det inte tillräckligt belopp får användaren ett felmeddelande. 
Flera try-catches har satts i metoden för att förhindra att programmet krashar av fel inmatning.

Withdraw(Users LoggedIn);
Metoden läser in vilken användare som använder programmet.
Metoden läser in arrayen från UsersList.
I metoden Withdraw(); presenteras användaren för de konton hen har med användning av en for-loop.
Metoden använder en while-loop för att ge användaren fler möjligheter att göra val.
Användaren får välja vilket konto som hen vill ta ut pengar från.
Metoden sätter en int som korrelerar med användarens input som sedan används för att söka efter vilken plats i arrayen kontot finns. 
Användaren får sedan frågan om det är rätt konto, om det inte stämmer börjar loopen om.
Användaren får skriva in vilket belopp hen vill ta ut, detta sätts som en double för att tillåta både kronor och ören.
En ny double sourceBalance skapas för kontot pengarna ska föras över från, där man splittar den kombinerade arrayen sourceAcc för att komma åt endast double-delenm i arrayen.
Finns det inte tillräckligt belopp får användaren ett felmeddelande. 

För att ta ut pengar från behöver användaren sedan mata in sin pinkod på nytt.
Om pinkoden stämmer skapas ny double sourceBalance skapas för kontot pengarna ska tas ut från, där man splittar den kombinerade arrayen sourceAcc för att komma åt endast double-delenm i arrayen.

Beloppet användaren skrivit in subtraheras sedan från LoggedIn.accountValue[sourceAccIndex] - dvs kontots double värde som är deklarerat i StoreUsers.
Användaren får meddelandet att uttaget har lyckats och kommer sedan till UserAccInfo där hen ser balansen hos sina konton.
Flera try-catches har satts i metoden för att förhindra att programmet krashar av fel inmatning.

Om pinkoden inte stämmer får användaren ett felmeddelande och meddelandet att hen använt ett av tre försök, (här används count för den lagrade användaren för att räkna antalet felslag) sedan får hen mata in pin igen.
Om pinkoden matas in fel tre gånger får användaren ett felmeddelande att hen använt sina försök, kontot är låst och hen behöver kontakta banken för att låsa upp kontot. 

