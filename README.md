 BullsAndCows
===============
#Web Services and Cloud – Practical Exam – September 2014

Task description 
##Bulls and Cows game description 
Implement the server logic of the Bulls and Cows game. The rules of the game are: <br />
1.	Both players think up a 4 digits, consisting of the digits 0-9, with no repeating digits <br />
2.	We will name one of the players "red player" and the other one "blue player" <br />
3.	The game is played in turns, a player is randomly selected to have the first turn <br />
4.	The player who is in turn to play tries to guess the opponent's number: <br />
•	He receives information about his guess in the forms of "count of bulls" and "count of cows" <br />
•	A "bull" is a correct digit at the correct position  <br />
•	A "cow" is a correct digit at the wrong position <br />
•	E.g. if the opponent's number is 1234 and the current player guesses "4631", then he has 1 bull (3) and 2 cows (1 and 4) <br />
5.	It becomes the other player's turn. <br />
6.	Steps 4 and 5 are repeated until someone guesses the opponents number (i.e. has 4 "bulls") 
The game always ends with one player winning<br />
##Game logic 
The game logic is performed as follows: <br />
1.	A user registers an account, providing credentials (username and password) <br />
2.	The user can login into their account using their credentials (username and password) <br />
•	S/he receives an access token that is used to authenticated theirself in the system 
3.	An authenticated user creates a game <br />
•	The game is created and is marked as available for joining <br />
•	The creator user is marked as red player <br />
•	S/he provides a four non-repeating digits that are their number (called user-number) <br />
4.	Another authenticated user joins the game  <br />
•	S/he provides a four non-repeating digits, that are their number (called user-number) <br />
•	He is marked as blue player <br />
5.	When a blue player joins a game: <br />
•	The server randomly decides which player starts first  <br />
•	For explanation purposes, let's assume the red  is chosen <br />
•	The creator of the game receives a notification that their game now has a blue player <br />
•	The player in turn receives a notification that it is their turn in the game <br />
•	The game can be played <br />
6.	The player in turn (in our case - the red player) can make a guess against the number of their opponent (in our case - the blue player) <br />
•	They send four non-repeating digits (called guess-number) <br /> 
•	The server compares the guess-number against their opponents user-number and returns the corresponding bulls and cows <br />
•	If the guess-number is the same as the opponent's user-number (i.e. it has 4 bulls), the game is finished, and scores are applied <br />
•	The winner gets a score "won" <br />
•	The loser gets a score "lost" <br />
•	If the guess-number is not the same as the user-number, the server marks that the other player is in turn (in our case the blue) <br />
•	The other player receives a notification that their opponent have finished their turn <br />
7.	Repeat step 6 while one of the players guesses right the user-number of their opponent 
8.	When a player guesses the number of their opponent: <br />
•	The winner is given a score "won" and receives a notification that s/he has won the game  <br />
•	The loser is given a score "lost" and receives a notification that s/he has lost the game <br />
Every user can play many games simultaneously. <br />

