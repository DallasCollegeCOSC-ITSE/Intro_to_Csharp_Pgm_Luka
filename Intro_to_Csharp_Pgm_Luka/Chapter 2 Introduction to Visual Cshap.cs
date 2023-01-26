/* //////////////////////////////////////////////////////////////////////////
 *
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 *//* //////////////////////////////////////////////////////////////////////////
 *	Chapter 2 Intorduction to Visual C#
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *                          Topics
 *
 * 2.1 Getting started with Forms and Controls
 *
 * 2.2 Creating the GUI for Your First Visual C# Application: The Hello World Application
 *
 * 2.3 Introduction to C# Code
 *
 * 2.4 Writting Code for the Hellow World Application
 *
 * 2.5 Label Controls
 *
 * 2.6 Making Sense of IntelliSense
 *
 * 2.7 PictureBox Controls
 *
 * 2.7 Comments, Black Lines, and Indentation
 *
 * 2.9 Writing the Code to CLose an Application's FOrm
 *
 * 2.10 Dealing with Syntax Errors
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 *              ^2.1 Getting Started with Forms and Controls
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *              #Concept
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * The first step in creating a Visual C# application is creating the
 * application's GUI. You use the Visual Studio Designer, Toolbox, and Prop
 * erties window to build the application's form with the desired controls
 * and set each control's properties.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * In this chapter, you will create your first Visual C# application. Before
 * you start, however, you need to learn some fundamental consepts about
 * creating a GUI in Visual Studio. This section shows the basics of
 * editing forms and creating controls.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *                      #The Application's Form
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * When you start a new Visual C# project, Visual Studio automatically
 creates an  empty form and displays it in the Designer.
 Figure 2-1 shows an example. Think of empty form as a blank canas that can
 be used to create the application's user interface. You can add controls to
 the form, the form's size, and modify many of its characteristics. When the
 application runs, the form will be displayed on the screen.
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 * @Figure 2-1 A new project with a blank form displayed in the Designer
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * IF you take a closer look at the form, you will notice that it is enclosed
 * by a thin dotted line, known as a bounding box. As shown in Figure 2-2, the
 * bounding box has small sizing handles, which appear on the form's right edge,
 * bottom edge, and lower-right corner. When a boundsing box appears around
 * an object in the Designer, it indicates that the object is selected and
 * ready for editing.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *  @Figure 2-2 The form's bounding box and sizing handles
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 * You can easily resize the form with the mouse. When you position the mouse
 cursor any edge or corner that has a sizing handle, the cursor changes to
 a two-headed arrow(<->). Figure 2-3 shows examples.

 When the mouse cursor becomes a two-headed arrow, you can click and drag
 the mouse to resize form.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * @Figure 2-3 Using the mouse to redize the form
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * #Identifying Forms and Controls by Their Names
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * An application's GUI is made of forms and various controls.
  Each form and control in an application's GUI must have a name that
  identifies it. The blank form that Visual Studio initially creates
  in a new project is named Form1.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * #Note
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * Later in this book, you will learn how to change a form's name, but for now
 * , you will keep the default name, Form1.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *							The Priperties Window
 * //////////////////////////////////////////////////////////////////////////
 *

	//////////////////////////////////////////////////////////////////////////
	The apperance and other carasteristics of a GUI objet are determined by
	the object's properties. When you select an object in the Designer, that object's
	properties are displayed in the Properties window. For example, when the
	Form1 form is selected, its properties are displayed in the Properties
	window, as shown in Figure 2-4.
	//////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-4 The properties window, showing the selected objetc's properties
 5202 alic dr
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
			#Tip
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 Recall from Chapter 1 that if the Properties window is in Auto Hide mode,
 you can click its tab to open it. If you do not see the Properties window,
 click View on the menu bar. On the View menu, click Properties Window.
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 The area at the top of the Properties window shows the name of the object
 that is currently selected.

 You can see in Figure 2-4 that the name of the selected is Form1.
 B that is a scrollable list of properties.
 The list of properties has two columns: the left colimn shows each
 property's name, and the right column shows each property's value.

 For example, look at the form's Size property in Figure 2-4.
 Its value is 300, 300. This means that the form's size is 300 pixels wide
 by 300 pixels high. Next look at the form's Text property. The Text property
 determines the text that is displayed in the form's title bar.
 //////////////////////////////////////////////////////////////////////////
 *
 *
 //////////////////////////////////////////////////////////////////////////
 When a form is crated, its Text property is initially set to the same
 value as the form's name.

 When you start a new project, the blank form that appears in the Designer
 will always be named Form1, so the text Form1 will always appear in the
 form's title bar.
 In most cases, you want to change the value of the form's Text property
 to something more meaningful. For example, assume the Form1 form is
 currently selected. You can perform the following steps to change
 its test property to My First Program.
 //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
	~Steps
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 Step 1: In the Properties window, locate the Text property.

 Step 2: Double-click the word Form1 that currently appears as the Text
 property's value, and then use the Delete key to delete it.

 Step 3: Type My First Program in its place and press the enter key.
 The text My First Program will now appear in the form's title bar,
 as shown in Figure 2-5.
 //////////////////////////////////////////////////////////////////////////
 *
 *
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-5 The form's Text property value displayed in the form's title bar
 //////////////////////////////////////////////////////////////////////////
 *
 //////////////////////////////////////////////////////////////////////////
		#Note
 //////////////////////////////////////////////////////////////////////////
 * 
 //////////////////////////////////////////////////////////////////////////
 Changing an object's Text property does not change the object's name. For
 example, if you change the Form1 form's Text property to My First Program,
 the form's name is still Form1. You have changed only the text that is 
 displayed in the form's title bar.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Earlier, we discussed how to use the moyse to resize a form in the Designer.
 An alternative method is to change the form's Size property in the
 Properties window.
 For example, assume the Form1 form is currently selected.
 You can perform the following steps to change its size to 400
 pixels wide by 100 pixels high.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 ~Steps
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Step 1: In the Properties window, locate the Size property.

 Step 2: Click inside the area that holds the Size property's
 value, and then delete the current value.

 Step 3: Type 400, 100 in its place and press the enter key.
 The form will be resized as shown in Figure 2-6
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-6 The form's size changed to 400 by 100
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #Note
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Notice in Figure 2-6 that the Alphabetical button is selected near the top
 of the properties window. This causes the properties to be displayed in 
 alphabetical order. Alternatively, the Categorized button can be selected,
 which causes the properties to be displayed in groups. The alphabetical
 listing is the default selection, and most of the time, it makes it easier
 to locate specific properties.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 #Adding Controls to a Form
 //////////////////////////////////////////////////////////////////////////
 
 When you are ready to create controls on the application's form, you use the
 Toolbox. Recall from Chapter 1 that the Toolbox usually appeats on the left
 side of the Visual Studio environment. If the Toolbox is in Auto Hide mode,
 you can click its tab to open it. Figure 2-7 shows an example of how the 
 Toolbox typically appears when it is open.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-7 The Toolbox
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #Tip
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Recall from chapter 1 that if you do not see the Toolbox or its tab,
 click View on the menue bar and then click Toolbox.
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 The Toolbox shows a scrollable list of controls that you can add to a form.
 Top add a control to a form, you simply find it in the Toolbox
 and then double-click it. The control will be created on the form. For ex
 , suppose you want to create a Button control on the form. You find it in 
 the Toolbox, as shown in Figure 2-8, double-click it, and a Button control
 will appear on the form.
 

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-8 Creating a Button control
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
								#Tip
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 You can also click and drage controls from the Toolbox onto the form.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
					#Resizing and Moving Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Take a closer look at the Button control that is shown on the form in FiFigure 2-8.
 Notice that it is enclosed in a bounding box with sizing handles. This indicates 
 that the control is currently selected. When a control is selected, you can use
 the mouse to resize it in the same way that you learned to resize a form earlier. 

 You can also use the mouse to move a control to a new location on the form. 

 Position the mouse cursor inside the control, and when the mouse curso
 r becaomes a four-headed arrow, you can click and drag the control
 to a new location.
 Figure 2-9 shows a form with a Button control that has been enlarged and moved.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-9 A Button control resized and moved
 //////////////////////////////////////////////////////////////////////////



 //////////////////////////////////////////////////////////////////////////
 #Deleting a Control
 //////////////////////////////////////////////////////////////////////////
 Deleting a contril is simple: you select it and then press the Delete key
 on the keyboard.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #More about Button Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 You learned earlier that each form and each control on an application's GUI
 must have a name that identifies it. When you create Button controls,
 they are automatically given default names such as button1, button2 and so
 forth. Button controls have a Text property, which holds the text that is
 displayed on the face of the button. When a button control is created,
 its Text property is initiallt set to the dame value as the Button
 control's name. As a result, when you create a button contril, its name
 will be displayed on the face of the button. For example, the form in
 Figure 2-10 controls three Button controls
 named button1, button2, and button3.

 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Figure 2-10 A form with three Button controls
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 After you create a Button control, you should always change its Text
 property. The text that is displayed on a button should indicate what
 the button will do when it is clicked.
 For ex, a button that calculates an average might have the text Calculate
 Average display on it, and a button that prints a report might have the
 text Print Report displayed on it. Here are the steps you perform to
 change a Button control's Text property:

 //////////////////////////////////////////////////////////////////////////
 Steps
 //////////////////////////////////////////////////////////////////////////
 Step 1: Make sure the Button control is selected. (IF you don't see the bounding box and sizing handles around the control, just click the contril to select it.)

 Step 2: In the Properties window, locate the Text property.

 Step 3: Click inside the area that holds the Text property's value,
 and then delete the current value. Then, type the new text in its place
 and press the enter key.  The new text will be displayed on the button.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-11 shows an example of how changing a Button control's Text property
 changes the text display on the face of the button.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-11 A Button control's Text property changed
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Changing a Control's Name
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 A control's name identifies the control in the application's code and in 
 the Visual Studio environment. When you create a contril on an
 application's form, you should always change the control's name to
 something that is more meaningful than the dafult name that Visual Studio
 gives it. A controls name should reflect the purpose of the control.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 For example, suppose you've created a Button control to calculate an amount
 of tax. A default name such as button1 does not convey the button's purpose.
 A name such as calculatetaxButton would be much better
 . When you are working with the application's code and you see the name
 calculateTaxButton, you will know percisely which button the code is
 referring to.

 You can change a control's name by changeing its name propertly. Here are the steps:


 //////////////////////////////////////////////////////////////////////////
 Step1: Make sure the controls is selected. (If you do not see the bounding box and sizing handles around the control, just click the control to select it.)

 Step 2: In the Properties window, scroll up to the top of the list if properties. You should see the Name property, as shown in Figure 2-12. (The Name property is enclosed in parenthese to make it appear near the top of the alphabetical list of properties. This makes it easier to find.)

 Step 3: Click inside the area that holds the Name property's value and then delete the current name. Then, type the new name in its place and press the Enter key. You have successfully changed the name of the control

 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Figure 2-12 The Name property
 //////////////////////////////////////////////////////////////////////////
 

 //////////////////////////////////////////////////////////////////////////
 Figure 2-13 shows the Properties window after a Button control's name has
 been changed to calculateTaxButton
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-13 The Name property changed to calculateTaxButton
 //////////////////////////////////////////////////////////////////////////



 //////////////////////////////////////////////////////////////////////////
 Rules for Naming Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Control names are also know as identifiers. When nameing a control, you must follow these rules for C# identifiers:

 * The first character muct be one of the letters a through z or A through Z or an underscore character(_).
 * 
 * After the first character, you may use the letters a through z or A through Z, the digits 0 through 9, or underscores.

 *The name cannot contain spaces.

 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Table 2-1 lists some identifiers that might be used for Button control
 names and indicates whether each is a legal or illegal identifier in C#
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Table 2-1 Legal and illgal identifiers
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Because a control's name should reflect the control's purpose, programmers often find themselves creating names that are made of multiple words. For ex, consider the following button control names:
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 calculatetaxbutton
 printreportbutton
 displayeanimationbutton
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
Unfortunately, these names are not easily read by the human sys because the
words are not separated. Because we cannot have spaces in contril names,
we need to find another way to separate the words in a multiword control
names to make it more readable to the human eye.
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Most C# programmers address this problem by using the camelCase naming convention for controls. camelCase names are written in the following manner:

 * you begin writing the name with lowercase letters.
 * 
 * The first character of the second and subsequent words is written in uppercase
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 for ex, the following control names are written in camelCase:

 calculateTaxButton
 orintReportButton
 displayAnimationButton
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 note
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 This stlt of naming is called camelCase because the uppercase charactrers
 that appear in a name are sometimes reminiscent of a camel's humps.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 2.2 Creating the GUI for Your First Visual C# Application: The Hello World Application
 
 //////////////////////////////////////////////////////////////////////////
 When a student is learing computer programming, it is traditional to start
 by learning to write a Hello World program.
 A Hello World program is a simple program that merely displays the words
 "Hello World" on the screen. In this chapter you will create your first
 Visual C# application, which will be an event-driven Hello World program.
 When the finished application runs, it will display the form shown on the
 left in Figure 2-14. Notice that the form contains a button that reads
 Display Message. When you click the button, the window shown on the right
 in the figure will appear.
 //////////////////////////////////////////////////////////////////////////
 Figure 2-14 Screens displayed by the completed Hello World program
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 The process of creating this application is divided into two parts. First,
 you create the application's GUI, and second, you write the code that causes
 the Hello World message to appear when the user clicks the Display Message button.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 */