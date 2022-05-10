# CSharp - Questionnaire - Assignment

Questionnaire is an app that allows a student to train his/her knowledge about a subject by solving multiple choice questions.

For the moment the application is only console based and is still lacking some functionality. For this assignment you will be extending this functionality and also create a WPF application to serve as a graphical user interface.

**This repository contains the last version of the Questionnaire console application demonstrated by the teacher. Feel free to replace this one with your own app.**

## WPF Main Window

Start by creating a new project inside the `QuestionnaireApp` solution of the type `WPF Application (.NET Core)` and make sure to target `.NET 5` or `.NET 6`.

The `MainWindow` will be the window used for displaying questions and solving them. The idea is that at least the following components are shown to the user:

* The name of the app (pick something nice)
* The question itself
* An image that accompanies the question (use a placeholder for the time being)
* The possible multiple choice answers with a way to select the correct option
* A solve/next button
* A stop button
* The user's score
* A progress bar to show the user's progress (number of questions solved versus number of questions remaining)
* A footer with a note about the author of the app. For example `This app was created by ...`

Feel free to add other things to the GUI or style them as you wish. Just make sure to use colors that agree with each other. Also make sure to use the same style throughout your application.

For the time being you do not need to bind the actual question data to the GUI. Feel free to use some fake question texts.

If you wish you can also experiment with styles in C#. This allows you to apply styles to similar components or target specific components. More info at [How to create a style for a control (WPF .NET)](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/controls/how-to-create-apply-style?view=netdesktop-6.0&viewFallbackFrom=netdesktop-5.0). While it takes some time to learn, it will pay of in the long term.

## Creating a Library

Before we can start using the application logic we first have to transfer the classes from the console application to the WPF application. However, copy pasting them is not a good idea here.

A better solution is to create a library of the classes. Check the course on how to create a library in C#.

This library can then be shared between both the console application and the WPF application.

## Playing

Setup the Questionnaire database when the main window is loaded. Select a random question from the database and populate the UI with the data from the question.

Allow the player to select an answer using the buttons / radio buttons. Try to solve this using a single event handler for all the buttons. Select a new question when the player has chosen his/her answer.

Track how many questions the player has already solved / correctly / incorrectly.

## Questionnaire Game

Notice that your WPF application already contains quitte a lot of game logic.

It

* keeps track of the current question
* keeps track of the number of correct and wrong selected answers
* ...

A lot of this can be abstracted away into a sort of `Game` class.

The `Game` class could have the following public interface:

```
##############################################
# Game
##############################################
##############################################
# + Game(numberOfQuestions: int)
# + CurrentQuestion(): MultipleChoiceQuestion
# + SelectAnswer(index: int): bool
##############################################
```

This is a proposition. Alterations might be required for your specific case.

## Future

While the following steps are not yet documented this is what the future will probable bring.

* Scoreboard
* Adding Questions
* Database connection
* ...
