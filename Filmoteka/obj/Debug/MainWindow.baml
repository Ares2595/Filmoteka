   M S B A M L   `   `   `  ����D  @Filmoteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Filmoteka	Filmoteka  5   	       Filmoteka.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Filmoteka     5   	   -   5          � Title$  
MainWindow��5   	   $��606.579��6   $��1077.632��6-   .��5
      � #��� ��6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ label��5      $��	Filmoteka��6   $
��Left=�63   $��
440,10,0,0q�6N   $	��Top=�6b   $��59��6z   $	��176��6�   $��36(�6�   �� 5   
   -   5         ��Name$ addingMovie��5      $��
Dodaj film��6&   $
��Left=�6;   $��211,101,0,0q�6V   $	��Top=�6k   $	��130��6�   $��42��6�   6�   �� 5   
   -   5        $ but_save��5      $��Zapisz��6#   $
��Left=�64   $��549,101,0,0q�6O   $	��Top=�6d   $	��130��6|   $��42��6�   6�   �� 5   
   -   5        $ but_load��5      $��Wczytaj��6#   $
��Left=�65   $��716,101,0,0q�6P   $	��Top=�6e   $	��130��6}   $��42��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridLastWatched��5      $
��Left=�60   $	��Top=�6K   $��
32,184,0,0q�6c   $	��382��6w   $	��466��6�      
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��211,163,0,0q�6B   $
��Wrap=�6W   $��Ostatnio oglądane��6k   $	��Top=�6�     5   
   -   5        $ dataGridTheBest��5      $
��Left=�6,   $	��Top=�6G   $��558,184,0,0q�6_   $	��382��6t   $	��466��6�    . 6�   �� 5   
   -	   5        $ 
textBlock2��5      $
��Left=�6(   $��749,163,0,0q�6C   $
��Wrap=�6X   $��	Najlepsze��6l   $	��Top=�6}   �� 5   
   -
   5        $ but_viewMovies��5      $��	Wyświetl��6)   $
��Left=�6<   $��378,101,0,0q�6W   $	��Top=�6l   $	��130��6�   $��42��6�   6�   5      5      