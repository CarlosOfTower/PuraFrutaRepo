   M S B A M L   `   `   `  ����D  @PuraFruta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PuraFruta.WindowsPuraFruta.Windows  5   	   &     PuraFruta.Windows.AddStockWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PuraFruta.Windows     5   	   -   5          � Title$  Añadir Stock��5   	   $	��200��6   $	��700��6.   .��5
      � $
��Left=�6   $
��50,0q�6&   .+�5   
   ��  �� Orientation$ Vertical=�6   $	��600��6,   $
��0,20q�68   .+�5      �� $ 
Horizontal=�6   $��Center=�62   $
��0,20q�6M   .+�5      �� $	��200��6a   ��6   �� *Fruits+ �� SelectedItem 6:   �� *SelectedFruit+6a   �� 5      $��50��62   $
��10,0q�6=   ��6   �� *Amount+6=   �� 5      $	��100��67   ��6   �� *	FruitUnit+67   5      �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� $!��Precio de compra por Unidad��6   $	��160��6?   $	��0,2q�6K   �� 5      $	��100��6=   $	��5,0q�6I   ��6   �� *PriceUnitPurchase+6I   �� 5      $��
€/Unidad��6   $��2,2,10,0q�6,   5      �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� $ ��Precio de venta por Unidad��6   $	��160��6>   $	��0,2q�6J   �� 5      $	��100��69   $	��5,0q�6E   ��6   �� *PriceUnitSell+6E   �� 5      $��
€/Unidad��6   $��2,2,10,0q�6,   �� 5      $��Añadir��6   $��50��6N   
��������6*   �� *AddStockCommand+6Y   5      9� 5      $!��Añadir nuevo tipo de fruta��6   $
��Left=�6;   $��1q�6V   
���   �$
��0,20q�6~   $��10q�6�   $	��550��6�   .��5      �� $ Vertical=�6   .+�5       �� $ 
Horizontal=�6!   $��Center=�6:   .+�5!      �� $��Nombre: ��6$   �� 5"      $	��267��6@   ��6"   �� *NewFruitName+6@   5#      �� 5$      $ 
Horizontal=�6!   $��Center=�6:   $	��0,5q�6U   .+�5%      �� $��
Cantidad: ��6$   �� 5&      $��50��6B   $
��10,0q�6M   ��6"   �� *NewFruitAmount+6M   �� 5'      $��Unidad: ��6$   �� 5(      $	��150��6p   ��6#   �� *FruitUnitsList+ 6J   �� *NewFruitUnit+6p   5)      �� 5*      $ 
Horizontal=�6!   $��Center=�6:   .+�5+      �� $!��Precio de compra por Unidad��6$   $	��160��6G   $	��0,2q�6S   �� 5,      $	��100��6M   $	��5,0q�6Y   ��6"   �� *NewFruitPriceUnitPurchase+6Y   �� 5-      $��
€/Unidad��6$   $��2,2,10,0q�64   5.      �� 5/      $ 
Horizontal=�6!   $��Center=�6:   $	��0,5q�6U   .+�50      �� $ ��Precio de venta por Unidad��6$   $	��160��6F   $	��0,2q�6R   �� 51      $	��100��6I   $	��5,0q�6U   ��6"   �� *NewFruitPriceUnitSell+6U   �� 52      $��
€/Unidad��6$   $��2,2,10,0q�64   �� 53      $��Añadir��6!   $��50��6Y   
��������62   �� *AddNewFruitCommand+6d   54      �� 55      $ 
Horizontal=�6!   $��Center=�6:   .+�56      �� $%��Descripcion de Fruta (opcional)��6$   $��2,2,10,0q�6K   �� 57      $	��340��6G   $	��5,0q�6S   ��6"   �� *NewFruitDescription+6S   58      59      5:      5;      5<      5=      