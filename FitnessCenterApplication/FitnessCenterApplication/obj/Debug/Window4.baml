   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   &     FitnessCenterApplication.Window4   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	     � Title$  Абонементы��5   	   $	��400��6   $	��600��6)    � 
ResizeMode$ CanMinimize=�65    � WindowStartupLocation$ CenterScreen=�6N   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AbonnementsDataGrid��5
      $
��Left=�60   $	��175��6K   $��	50,50,0,0q�6X   $	��Top=�6k   $	��500��6�   �� 5   
   -   5         ��Name$ NewID_tb��5      $
��Left=�6$   $��23��6?   $��
50,271,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $��60��6�   �� 5   
   -   5        $ ID_tb��5      $
��Left=�6!   $��23��6<   $��
50,243,0,0q�6H   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $��60��6�   �� 5   
   -   5        $ 
NewName_tb��5      $
��Left=�6&   $��23��6A   $��115,271,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ Name_tb��5      $
��Left=�6#   $��23��6>   $��115,243,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ NewPrice_tb��5      $
��Left=�6'   $��23��6B   $��240,271,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $��75��6�   �� 5   
   -   5        $ Price_tb��5      $
��Left=�6$   $��23��6?   $��240,243,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $��75��6�   �� 5   
   -   5        $ 
Descrip_tb��5      $
��Left=�6&   $��23��6A   $��320,243,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��230��6�   �� 5   
   -	   5        $ NewDescrip_tb��5      $
��Left=�6)   $��23��6D   $��320,271,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��230��6�   �� 5   
   -
   5         ��Name$ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��
50,320,0,0q�6R   $	��Top=�6f   $	��164��6~   6�   �� 5   
   -   5        $ DeleteButton��5      $��Удалить��6'   $
��Left=�69   $��219,320,0,0q�6T   $	��Top=�6i   $	��163��6�   6�   �� 5   
   -   5        $ ChangeButton��5      $��Изменить��6'   $
��Left=�6:   $��387,320,0,0q�6U   $	��Top=�6j   $	��163��6�   6�   �� 5   
   -   5        $ ReloadButton��5      $�� ��6'   $
��Left=�62   $��	50,20,0,0q�6M   $	��Top=�6`   $��25��6x   $��25��6�   ��5      �� 5       �� ImageSource$I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6    j� Stretch$ Uniform=�6o   5      5      5      