   M S B A M L   `   `   `  ����D  @Filmoteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Filmoteka	Filmoteka  5   	       Filmoteka.ViewMovies   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Filmoteka     5   	     � Title$  Dodawanie filmu��5   	   $��606.579��6!   $��1077.632��62   .��5	      � #��� ��6   .+�5
   
   �� -   5         ��Name$ 
but_return��5
      $��Powrót��6%   $
��Left=�66   $��	39,35,0,0q�6Q   $	��Top=�6d   $��91��6|   $��34��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridMovies��5      $
��Left=�6+   $��
370,10,0,0q�6F   $	��Top=�6Z   $	��556��6r   $	��690��6      
IsReadOnly .  � ContextMenu 5      �� 5      .@�5      m� -   5        $��Edytuj��5      6/   m� 5      -   5        $��Usuń��5      6-   5      5      �� 5   
   -   5         ��Name$ textBoxName��5      $
��Left=�6'   $��33��6B   $��141,149,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��176��6�   $��20(�6�   �� 5   
   -   5         ��Name$ label��5      $��Co��6   $
��Left=�6,   $��
96,145,0,0q�6G   $	��Top=�6[   $��20(�6s   $
��Bold"�6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��141,199,0,0q�6@   $	��Top=�6U   $	��176��6m   $��33��6y   $��20(�6�   6�   �� 5   
   -   5        $ label1��5      $��Po czym��6    $
��Left=�62   $��
43,195,0,0q�6M   $	��Top=�6a   $��20(�6y   $
��Bold"�6�   �� 5   
   -	   5        $ 
but_search��5      $��Szukaj��6%   $
��Left=�66   $��226,247,0,0q�6Q   $	��Top=�6f   $��91��6~   $��34��6�   6�   �� 5   
   -
   5        $ comboBoxCategory��5      $
��Left=�6-   $��141,149,0,0q�6H   $	��Top=�6]   $	��176��6u   $��33��6�   $��20(�6�   $y�	Collapsed=�6�   �� 5   
   -   5        $ but_showAll��5      $��Pokaż wszystko��6&   $
��Left=�6?   $��226,286,0,0q�6Z   $	��Top=�6o   $��91��6�   $��34��6�   6�   5      5      