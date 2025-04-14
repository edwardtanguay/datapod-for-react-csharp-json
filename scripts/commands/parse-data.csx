#load "../classes/Flashcard.csx"
#load "../qtools/qcli.csx"

var flashcards = Flashcard.GetFlashcardsFromTextFile("../../data/flashcards.txt");
Flashcard.SaveToJson(flashcards, "../../parseddata/flashcards.json");
qcli.message("Flashcards parsed and saved to JSON.", "success");
