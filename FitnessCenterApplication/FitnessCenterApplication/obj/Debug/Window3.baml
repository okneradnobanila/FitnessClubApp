   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   &     FitnessCenterApplication.Window3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	   -   5          �Name$  ClientsWindow��5   	    � Title$ Клиенты��5   	   $	��400��6   $	��900��6&    � 
ResizeMode$ CanMinimize=�62    � WindowStartupLocation$ CenterScreen=�6K   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ClientsDataGrid��5
      $
��Left=�6,      AutoGenerateColumns . $	��150��6b   $��	50,50,0,0q�6o   $	��Top=�6�   $	��800��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5         ��Name$ Surname_textbox��5      $
��Left=�6+   $��50��6F   $��105,205,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $��80��6�   �� 5   
   -   5        $ 
ID_textbox��5      $
��Left=�6&   $��23��6A   $��
50,205,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $��50��6�   �� 5   
   -   5        $ Password_textbox��5      $��50��6,   $��790,205,0,0q�68   $
 Wrap=�6M   $	��Top=�6a   $
��Left=�6y   $��60��6�   $ -0.717,0.565&�6�   �� 5   
   -   5        $ Login_textbox��5      $
��Left=�6)   $��50��6D   $��645,205,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��140��6�   �� 5   
   -   5        $ Address_textbox��5      $
��Left=�6+   $��50��6F   $��495,205,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��145��6�   �� 5   
   -   5        $ DataBirth_textbox��5      $
��Left=�6-   $��23��6H   $��430,205,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $��60��6�   �� 5   
   -	   5        $ Phone_textbox��5      $
��Left=�6)   $��23��6D   $��340,205,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $��85��6�   �� 5   
   -
   5        $ Patronymic_textbox��5      $
��Left=�6.   $��50��6I   $��265,205,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $��70��6�   �� 5   
   -   5        $ Name_textbox��5      $
��Left=�6(   $��50��6C   $��190,205,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $��70��6�   �� 5   
   -   5        	 ��Name$	 AddClientButton��5      $%��Добавить клиента��6*   $
��Left=�6E   $��645,261,0,0q�6`   $	��205��6u   $��25��6�   $	��Top=�6�   6�   �� 5   
   -   5        $	 DeleteClientButton��5      $%��Удалить клиента *��6-   $
��Left=�6I   $��645,291,0,0q�6d   $	��205��6y   $��25��6�   $	��Top=�6�   6�   �� 5   
   -   5        $	 ChangeClientButton��5      $'��!Изменить клиента *��6-   $
��Left=�6J   $��645,321,0,0q�6e   $	��205��6z   $��25��6�   $	��Top=�6�   6�   o� 5   
   $
��Left=�6   $��25��6*   $	��Top=�66   $	��894��6N   .@�5      m� -   5        
 m�Name$
 InfoItem��5      $�� ��6)   $��25��6K   $��25��6W   $
��Left=�6b   $��5,0,0,0q�6}   ��5      �� 5       �� ImageSource$N HC:\Users\acer\source\repos\FitnessCenterApplication\exclamation_mark.ico��6!    j� Stretch$ Uniform=�6x   5      m� 5      -   5        $
 
ReloadItem��5      $�� ��6+   $��25��6N   $��25��6Z   $
��Left=�6e   $��5,0,0,0q�6�   ��5      �� 5      $I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6!   $ Uniform=�6s   5!      5"      �� 5#   
   -   5        $ NewID_textbox��5#      $
��Left=�6)   $��
50,296,0,0q�6D   $
 Wrap=�6X   $��50��6l   $	��Top=�6w   $��23��6�   �� 5$   
   -   5        $ NewAddress_textbox��5$      $
��Left=�6.   $��39��6I   $��495,296,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��145��6�   �� 5%   
   -   5        $ NewDateBirth_textbox��5%      $
��Left=�60   $��25��6K   $��430,296,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $��60��6�   �� 5&   
   -   5        $ NewPhone_textbox��5&      $
��Left=�6,   $��25��6G   $��340,296,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $��85��6�   �� 5'   
   -   5        $ NewPatronymic_textbox��5'      $
��Left=�61   $��265,296,0,0q�6L   $
 Wrap=�6a   $��70��6u   $��50��6�   $	��Top=�6�   �� 5(   
   -   5        $ NewName_textbox��5(      $
��Left=�6+   $��190,296,0,0q�6F   $
 Wrap=�6[   $��70��6o   $��50��6z   $	��Top=�6�   �� 5)   
   -   5        $ NewSurname_textbox��5)      $
��Left=�6.   $��105,296,0,0q�6I   $
 Wrap=�6^   $��80��6r   $��50��6}   $	��Top=�6�   �� 5*   
   $C��=Поля для ввода измененных данных:��6   $
��Left=�6<   $��
50,265,0,0q�6W   $	��Top=�6k   5-      5.      