   M S B A M L   `   `   `  ����D  @Filmoteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Filmoteka	Filmoteka  5   	       Filmoteka.EditMovie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Filmoteka     5   	     � Title$  Edytowanie filmu��5   	   $��606.579��6"   $��1077.632��63   .��5	      � #��� ��6   .+�5
   
   �� -   5         ��Name$ 
but_return��5
      $��Powrót��6%   $
��Left=�66   $��	39,35,0,0q�6Q   $	��Top=�6d   $��91��6|   $��34��6�   6�   �� 5   
   -   5         ��Name$ textBoxTitle��5      $
��Left=�6(   $��40��6C   $��370,109,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��498��6�   $��20(�6�   �� 5   
   -   5        $ textBoxYear��5      $
��Left=�6'   $��40��6B   $��370,219,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��498��6�   $��20(�6�   �� 5   
   -   5         ��Name$ sliderRating��5      $
��Left=�6'   $��370,173,0,0q�6B   $	��Top=�6W   $��42��6o   $	��498��6{    �� TickPlacement$ BottomRight=�6�    �� IsSnapToTickEnabled .  � Value$ 5Q�6�   �� 5   
   -   5         ��Name$ labelRating��5      $
��Left=�6�   $	��Top=�6�   $��330,161,0,0q�6�   $��20(�6�   ��6%   �� 	 �� ElementName$	 sliderRating��
 �� Path$
 Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ label1��5      $��Tutuł��6    $
��Left=�60   $��262,109,0,0q�6K   $	��Top=�6`    J� RenderTransformOrigin$ 1.184,0.846&�6x   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1_Copy��5      $��Ocena��6%   $
��Left=�65   $��252,161,0,0q�6P   $	��Top=�6e   $ 1.184,0.846&�6}   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1_Copy1��5      $��Rok produkcji��6&   $
��Left=�6>   $��180,219,0,0q�6Y   $	��Top=�6n   $ 1.184,0.846&�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -	   5        $ textBoxComment��5      $
��Left=�6*   $	��134��6E   $��370,355,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��498��6�   $��20(�6�   �� 5   
   -
   5        $ label1_Copy2��5      $��	Komentarz��6&   $
��Left=�6:   $��208,355,0,0q�6U   $	��Top=�6j   $ 1.184,0.846&�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��370,273,0,0q�6@   $	��Top=�6U   $	��178��6m   $��32��6y   $��20(�6�   �� 5   
   -   5        $ label1_Copy3��5      $��	Kategoria��6&   $
��Left=�6:   $��220,273,0,0q�6U   $	��Top=�6j   $ 1.184,0.846&�6�   $��20(�6�   $
��Bold"�6�   c� 5   
   -   5         c�Name$ toolBar��5      $
��Left=�6#   $��370,315,0,0q�6>   $	��Top=�6S   $��26��6k   $	��498��6w   �� 5   
   -   5        $ but_saveMovie��5      $��Zapisz��6(   $
��Left=�69   $��951,518,0,0q�6T   $	��Top=�6i   $��91��6�   $��34��6�   6�   5      5      