   M S B A M L   `   `   `  ����?  ;menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:menumenu  5   	       menu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:menu     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� -   5         o�Name$ 
mPrincipal��5
      $��24��6#   $	��Top=�6/   $��
0,0,-0.4,0q�6G   .@�5      m� -   5         m�Name$ mArchivo��5      $��_Archivo��6)   $��24��6;   $��55��6G   .@�5      m� -   5        $ mArchivoNuevo��5      $��_Nuevo��62   $��24��6B   .@�5      m� -   5        $ mArchivoNuevoProyecto��5      $��	_Proyecto��6>   $
��Left=�6Q   $��24��6l   $	��200��6x   5      �� 5      $
��Left=�6   $��1��67   $	��200��6B   m� 5      -   5        $ mArchivoCerrar��5      $��_Cerrar��63   $��24��6D   �� 5      $
��Left=�6   $��1��67   $	��200��6B   m� 5      -   5        $ mArchivoGuardar��5      $��_Guardar��64   $��24��6F   m� 5      -   5        $ mArchivoGuardarComo��5      $��G_uardar como...��68   $��24��6R   �� 5      $
��Left=�6   $��1��67   $	��200��6B   m� 5      -   5        $ mArchivoSalir��5      $��_Salir��62   $��24��6B    m� Icon 5      �� 5      $J��DD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/exit_32x32.png��6    6p   5      5      m� 5      -	   5        $ mEditar��5      $��_Editar��6(   $��24��69   $��45��6E   .@�5      m� -
   5        $ mEditarBuscarYReemplazar��5      $��_Buscar y reemplazar��6=   $��24��6[    5      �� 5       $L��FD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/search_32x32.png��6    6r   5"      �� 5#      $
��Left=�6   $��1��67   $	��200��6B   m� 5$      -   5        $ mEditarDeshacer��5$      $��	_Deshacer��64   $��24��6G    5%      �� 5&      $J��DD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/undo_32x32.png��6    6p   5(      m� 5)      -   5        $ mEditarRehacer��5)      $��_Rehacer��63   $��24��6E    5*      �� 5+      $J��DD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/redo_32x32.png��6    6p   5-      �� 5.      $
��Left=�6   $��1��67   $	��200��6B   m� 5/      -   5        $ mEditarCortar��5/      $��_Cortar��62   $��24��6C    50      �� 51      $I��CD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/cut_32x32.png��6    6o   53      m� 54      -   5        $ mEditarCopiar��54      $��Co_piar��62   $
��Left=�6C   $��24��6^   $��190.4��6j    55      �� 56      $J��DD:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/copy_32x32.png��6    6p   58      m� 59      -   5        $ mEditarPegar��59      $��Pe_gar��61   $
��Left=�6A   $��24��6\   $��190.4��6h    5:      �� 5;      $K��ED:/Programacion/wpf/ejemplo_2_menu/menu/menu/imagenes/paste_32x32.png��6    6q   5=      5?      5@      �� 5A   
   -   5         ��Name$ 	tcCliente��5A      $
��Left=�6(   $	��199��6C   $��
231,94,0,0q�6P   $	��Top=�6d   $	��352��6|   .@�5B      �� -   5         ��Name$ tiNombre��5B      $��Nombre��6(   .��5C      � ���	#FFE5E5E5.+�5D      �� -   5         ��Name$ 	lblNombre��5D      $��Nombre��6/   $
��Left=�6@   $��	10,35,0,0q�6[   $	��Top=�6n   �� 5E      -   5         ��Name$ 	txtNombre��5E      $
��Left=�61   $��23��6L   $��	81,35,0,0q�6X    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��120��6�   5F      5G      �� 5H      -   5        $ tiDireccion��5H      $��
Dirección��6+   .��5I      � ���	#FFE5E5E5.+�5J      �� -   5        $ lblDireccion��5J      $��
Dirección��62   $
��Left=�6F   $��	10,26,0,0q�6a   $	��Top=�6t   �� 5K      -   5        $ txtDireccion��5K      $
��Left=�64   $��23��6O   $��	98,26,0,0q�6[   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   5L      5M      �� 5N      -   5        $ tiTelefonos��5N      $��
Teléfonos��6+   $
��Left=�6>   $��63��6Y   $��
-1.6,0,0,0q�6d   $��20��6x   $	��Top=�6�   .��5O      � ���	#FFE5E5E5	 � ColumnDefinitions	 5P      �� 5Q      $	��16* �6+   �� 5R      $
��157* �6+   .+�5T      �� -   5        $ txtTelefono��5T      $
��Left=�63   $��23��6N   $��51.6,29,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5U      -   5        $ lblTelefono��5U      $��	Teléfono��61   $
��Left=�6D   $��	10,29,0,0q�6_   $	��Top=�6r   $��2��6�   5V      5W      5X      � 5Y   
   -   5        
 �Name$
 
pbCargando��5Y      $
��Left=�6*   $��23��6E   $��231,328,0,0q�6Q   $	��Top=�6f   $	��352��6~    � Maximum$	 300Q�6�   �� 5Z   
   -   5         ��Name$ btnFacturar��5Z      $��Facturar��6&   $
��Left=�69   $��
58,351,0,0q�6T   $	��Top=�6h   $��75��6�    � ContextMenu 5[      �� 5\      .@�5]      m� $��Menu item 1��6   m� 5^      $��Menu item 2��6   �� 5_      m� 5`      $��Menu item 3��6   5b      5d      5e      5f      