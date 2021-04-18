# CatalogUserControl
In this project I want to show the usability factors an interface must have for its optimal, convenient and pleasant usage.
For this purpose I have created a catalogue of products using the database Microsoft has available, specifically AdventureWorks2016, and I have used programming language C# and IDE Visual Studio 2019.
Below I present the installation process and the aspects I want to highlight about its usability



## Installation

  You can download the complete project if you wish to modify it for your own use.
Or you can go to the following link if you prefer to download and use [Catalog UserControl Library](https://github.com/miquelpaucasesnoves/) directly.


- When using the User Control go to Toolbox list and click right and select Add Tab from the menu.

- Once you have created the new Tab click right and then click Choose Item on the menu.

- Click on the browser button and search for the library where you have downloaded.

- Click on the OK button and the User Control will appear on the Toolbox list.

- You can now drag the component to your project.


## Usability 
 First of all I am going to mention the distribution of its components.
 
 <p align="center">
  <img width="508" height="228" src="https://github.com/miquelpaucasesnoves/CatalogUserControl/blob/main/ScreenShots/mainFormScreentShot.png">
</p>

  On the main form I have differentiated the selection section of categories, subcategories and language from the product information by inserting between them the title for the product model with a larger and more noticeable font.
  
  So the price will also stand out from the rest of product information I have also given this a different font as it is a detail clients want to know quickly.

  I have placed the product image in the centre of the form and just beneath this I have grouped the available sizes and colours so users can visualise the options quickly.For the language selection I have chosen a radio button for each language option as this is the ideal component in situations where only one element should be selected and can be done easily. 
  
 For the categories and subcategories I have used the combobox component. This allows you to have a list of categories / subcategories and also provides a clearer view of the form when you don't want to use it.
 
  In the detail form I have organised the common aspects by tabs. I have created 4 tabs:
  
         - Main product information.
         - Style details
         - Production data
         - Section to add or change product photo


 <p align="center">
  <img width="508" height="228" src="https://github.com/miquelpaucasesnoves/CatalogUserControl/blob/main/ScreenShots/detailFormScreentShot.png">
</p>

  I have used a vertical view, all elements are labels and textBox except the colours and size options where I have used a listview for rapid display. All Fields in the details form are read-only.
  
  In reference to the colours used, I have decided on two shades of blue on a white background. I believe this theme conveys order and tranquillity. I have highlighted the name fields in bold text and, as mentioned previously, I have only changed the font size on the two most important details: its label in the catalogue and its prise.



## Support and new input

If you encounter problems when using the User Control or if you believe it can be improved, please do not hesitate to open an issue in the repository. Any feedback is welcome.


## License 

This project does not currently have any license
