   M S B A M L   `   `   `  ����I  EPrueba_VaraAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Prueba_VaraAPIPrueba_VaraAPI  5   	       Prueba_VaraAPI.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Prueba_VaraAPI     5   	     � Title$  Mis Varamientos��5   	   $	��500��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � .+�5
   
   �� $��Total de registros:��6   $
��Left=�6.   $��	32,32,0,0q�6I   $	��Top=�6\   �� 5   
   $
��Left=�6   $��
149,37,0,0q�6/   $
��Wrap=�6C   $��	TextBlock��6W   $	��Top=�6h   �� 5   
   -   5        $��Registrar varamiento��5      $
��Left=�60   $��
599,21,0,0q�6K   $	��Top=�6_   $��47��6w   $	��183��6�   ���	#FF4FDA576�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_varamientos��5      $��10,82,18,21q�6+      AutoGenerateColumns$ False��6@      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre Informante��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *nombreInformante+  5      $ País��6%    63   �� *pais+  5      $ Estado��6%    65   �� *estado+  5      $ 
Finalizado��6%    69   �� *
finalizado+  5      $ Fecha avistamiento��6%    6A   �� *fecha+  5      $ Condición animal��6%    6?   �� *nombreInformante+  5      $	 num��6%    62   �� *nombreInformante+5      5      5      