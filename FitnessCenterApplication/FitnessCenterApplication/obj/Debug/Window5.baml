   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   &     FitnessCenterApplication.Window5   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	     � Title$+  %Продажи абонементов��5   	   $	��400��6%   $	��600��62    � 
ResizeMode$ CanMinimize=�6>    � WindowStartupLocation$ CenterScreen=�6W   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AbonnementsSalesDataGrid��5
      $
��Left=�65   $	��175��6P   $��	50,50,0,0q�6]   $	��Top=�6p   $	��500��6�   �� 5   
   -   5         ��Name$ ID_tb��5      $
��Left=�6"   $��23��6=   $��
50,243,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $��80��6�   �� 5   
   -   5        $ NewStart_tb��5      $
��Left=�6(   $��23��6C   $��305,271,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ NewClient_tb��5      $
��Left=�6)   $��23��6D   $��135,271,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��80��6�   �� 5   
   -   5        $ Abon_tb��5      $
��Left=�6#   $��23��6>   $��220,243,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $��80��6�   �� 5   
   -   5        $ 	NewEnd_tb��5      $
��Left=�6%   $��23��6@   $��430,271,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ NewID_tb��5      $
��Left=�6%   $��23��6@   $��
50,271,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $��80��6�   �� 5   
   -   5        $ 
NewAbon_tb��5      $
��Left=�6'   $��23��6B   $��220,271,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $��80��6�   �� 5   
   -	   5        $ 	Client_tb��5      $
��Left=�6%   $��23��6@   $��135,243,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $��80��6�   �� 5   
   -
   5        $ Start_tb��5      $
��Left=�6$   $��23��6?   $��305,243,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ End_tb��5      $
��Left=�6"   $��23��6=   $��430,243,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $��Добавить��6$   $
��Left=�67   $��
50,315,0,0q�6R   $	��Top=�6f   $	��163��6~   6�   �� 5   
   -   5        $ DeleteButton��5      $��Удалить��6'   $
��Left=�69   $��218,315,0,0q�6T   $	��Top=�6i   $	��163��6�   6�   �� 5   
   -   5        $ ChangeButton��5      $��Изменить��6'   $
��Left=�6:   $��386,315,0,0q�6U   $	��Top=�6j   $	��164��6�   6�   �� 5   
   -   5        $ ReloadButton��5      $�� ��6'   $
��Left=�62   $��	50,20,0,0q�6M   $	��Top=�6`   $��25��6x   $��25��6�   ��5      �� 5       �� ImageSource$I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6    j� Stretch$ Uniform=�6o   5      5      5      