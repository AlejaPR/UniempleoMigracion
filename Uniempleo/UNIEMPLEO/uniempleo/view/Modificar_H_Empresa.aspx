<%@ Page Title="" Language="C#" MasterPageFile="~/view/MasterEmpresa.master" AutoEventWireup="true" CodeFile="~/controller/Modificar_H_Empresa.aspx.cs" Inherits="view_Modificar_H_Empresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <SCRIPT language=Javascript>  
        function Letras(evt) {

  
          var charCode = (evt.which) ? evt.which : event.keyCode;

   
         if ((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123) || (charCode < 33 && charCode > 31) || (charCode < 9 && charCode > 7))

    
            return true;

      
      return false;
        }


       
 function Numeros(evt) {

    
        var charCode = (evt.which) ? evt.which : event.keyCode;

      
      if ((charCode > 47 && charCode < 58) || (charCode < 33 && charCode > 31) || (charCode < 9 && charCode > 7))

                
	return true;

            	
	return false;
        }

    
    function Caracteres(evt) {

            
	var charCode = (evt.which) ? evt.which : event.keyCode;

            
	if ((charCode > 47 && charCode < 58) ||  ((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123)) || (charCode < 33 && charCode > 31) || (charCode < 9 && charCode > 7))

  
              return true;

            
	return false;
        }
       
	 function Direccion(evt) {

            
	var charCode = (evt.which) ? evt.which : event.keyCode;

           
	 if ((charCode > 32 && charCode < 60) || ((charCode > 62 && charCode < 126)) || (charCode < 33 && charCode > 31) || (charCode < 9 && charCode > 7))

                
	return true;

            
	return false;
        }


   
  </SCRIPT>
    <style type="text/css">
        .auto-style38 {
            width: 100%;
        }
        .auto-style39 {
            color: #000000;
            font-size: large;
        }
        .auto-style40 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style38">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style39">Modifica tu hoja de vida</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td rowspan="3">
                <asp:GridView ID="GV_hoja_emp" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style40" DataSourceID="ODS_obtener_pempresa" GridLines="Horizontal" AutoGenerateEditButton="True">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_obtener_pempresa" runat="server" SelectMethod="obtenerEmpresa" TypeName="Data.DEmpresa" UpdateMethod="EditarEmpresa">
                    <SelectParameters>
                        <asp:SessionParameter Name="idemp" SessionField="id" Type="Int32" />
                    </SelectParameters>
					<UpdateParameters>
                        <asp:Parameter Name="IdE" Type="Int32" />
                        <asp:Parameter Name="nombreE" Type="String" />
                        <asp:Parameter Name="forma" Type="String" />
                        <asp:Parameter Name="direccionE" Type="String" />
                        <asp:Parameter Name="telefonoE" Type="String" />
                        <asp:Parameter Name="sector" Type="String" />
                        <asp:Parameter Name="empleados" Type="String" />
                        <asp:Parameter Name="nit" Type="String" />
                        <asp:Parameter Name="tipo" Type="String" />
                       
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

