#pragma checksum "C:\WebApp\Turnos\Views\Turno\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061aa6502e01815dd968965a4e5befce87fd4c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Turno_index), @"mvc.1.0.view", @"/Views/Turno/index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\WebApp\Turnos\Views\_ViewImports.cshtml"
using Turnos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WebApp\Turnos\Views\_ViewImports.cshtml"
using Turnos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"061aa6502e01815dd968965a4e5befce87fd4c05", @"/Views/Turno/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b9c7a7584d54ef9e045a44f17b50f6dc5da374", @"/Views/_ViewImports.cshtml")]
    public class Views_Turno_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turnos.Models.Turno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.print.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/locale/es.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
  
    ViewBag.title = "Asignación de Turnos";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"row\">\r\n    <div class=\"col s6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c056168", async() => {
                WriteLiteral("Médico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdMedico);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c057616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 12 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdMedico);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdMedico;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col s6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c059499", async() => {
                WriteLiteral("Paciente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c0510951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\WebApp\Turnos\Views\Turno\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdPaciente;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br>\r\n\r\n<div id=\"ModalTurno\" class=\"modal\">\r\n    <div class=\"modal-content\">\r\n        <h4>Turno</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c0512941", async() => {
                WriteLiteral(@"
            <div>
                <label>Inicio</label>
                <input type=""text"" id=""txtFechaHoraInicio"" readonly=""readonly""/>
            </div>

            <div>
                <label>Fin</label>
                <input type=""text"" id=""txtFechaHoraFin"" readonly=""readonly""/>
            </div>

            <div>
                <label>Nombre del Paciente</label>
                <input type=""text"" id=""txtPaciente"" readonly=""readonly""/>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""modal-footer"">
        <a href=""#"" id=""btnEliminar"" class=""modal-close waves-effect waves-red btn-flat"">Eliminar</a>
        <a href=""#"" id=""btnGuardar"" class=""modal-close waves-effect waves-red btn-flat"">Guardar</a>
        <a href=""#"" id=""btnCerrar"" class=""modal-close waves-effect waves-red btn-flat"">Cerrar</a>
    </div>

</div>

<div id=""CalendarioTurnos""></div>
 
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "061aa6502e01815dd968965a4e5befce87fd4c0515114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "061aa6502e01815dd968965a4e5befce87fd4c0516229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js\"></script>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c0517620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061aa6502e01815dd968965a4e5befce87fd4c0518716", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>
    $(document).ready(function () {
 
        $('.modal').modal(); //para que funcione los eventos show hide del modal
        var horarioDesde = """";
        var horarioAntes = """";
        var turnos = []; // es una array
        var turnoSeleccionado = [];

        ObtenerTurnosYActualizar($('#IdMedico').val());
 
        $('#IdMedico').change(function(){
            ObtenerTurnosYActualizar(this.value);
        });

        function ObtenerTurnosYActualizar(idMedico) {
            turnos = []; //inicializamos el array
            $.ajax({
                type: ""GET"",
                url: ""Turno/ObtenerTurno"",
                data: { 'IdMedico': idMedico },                
                success: function (datos) {
                    $.each(datos, function (i, v) {
                        //poner las iniciales en minuscula
                        turnos.push({
                            idTurno: v.idTurno,
                            idPaciente: v.idPaciente,
        ");
                WriteLiteral(@"                    idMedico: v.idMedico,
                            start: moment(v.fechaHoraInicio),
                            end: v.fechaHoraFin != null ? moment(v.fechaHoraFin): null,
                            paciente: v.paciente,
                        });
                    })
                    GenerarCalendario(turnos);
                },
                error: function () {
                    alert('Error al obtener turnos');
                }
            }); // ver aqui el cierre con ;
        }
 
        function GenerarCalendario(turnos) {
 
            //Funcion ajax para traer los horarios desde
            $.ajax({
                type: ""GET"",
                url: ""Medico/traerHorarioAtencionDesde"",
                data: { 'idMedico': $('#IdMedico').val() },
                async: false,
                success: function (resultado) {
                    horarioDesde = resultado;
                },
                error: function () {
                    ale");
                WriteLiteral(@"rt('Error al traer el ""horario de Atención desde"" del medico');
                }
            });
 
            //Funcion ajax para traer los horarios Hasta
            $.ajax({
                type: ""GET"",
                url: ""Medico/traerHorarioAtencionAntes"",
                data: { ""idMedico"": $('#IdMedico').val() },
                async: false,
                success: function (resultado) {
                    horarioAntes = resultado;
                },
                error: function () {
                    alert('Error al traer el ""horario de Atención hasta"" del medico');
                }
            });
 
            //eliminamos el calendario para mostrarlo posteriormente
            $('#CalendarioTurnos').fullCalendar('destroy');
 
            //mostramos el calendario
            $('#CalendarioTurnos').fullCalendar({
                contentHeight: 'auto',
                defaultDate: new Date(),
                slotLabelFormat: ""HH:mm"",
                defaultView: '");
                WriteLiteral(@"agendaWeek',
                header: {
                    left: 'prev,next today',
                    right: 'month,agendaWeek,agendaDay',
                },
                slotDuration: '00:30',
                nowIndicator: true,
                allDaySlot: false,
                selectable: true,
                eventLimit: true,
                minTime: horarioDesde,
                maxTime: horarioAntes,
                events: turnos,
                select: function(fechaHoraInicio, fechaHoraFin){
                    turnoSeleccionado = {
                        idTurno: 2,
                        start: fechaHoraInicio,
                        end: fechaHoraFin
                    };
                    AbrirPopup();
                },
                    eventClick: function (turnoClickeado){
                        turnoSeleccionado = turnoClickeado;
                        AbrirPopup();
                    }
            })
        
        }
            function Abrir");
                WriteLiteral(@"Popup()
            {
                $('#txtFechaHoraInicio').val(turnoSeleccionado.start.format('DD/MM/YYYY HH:mm'));
                $('#txtFechaHoraFin').val(turnoSeleccionado.end.format('DD/MM/YYYY HH:mm'));
                if (turnoSeleccionado.idTurno == 2){
                    $('#btnGuardar').show();
                    $('#btnEliminar').hide();
                    $('#txtPaciente').val($('#IdPaciente option:selected').text());
                }else{
                    $('#btnGuardar').hide();
                    $('#btnEliminar').show();
                    $('#txtPaciente').val(turnoSeleccionado.paciente);
                }
                $('#ModalTurno').modal('open');
            }

            $('#btnGuardar').click(function(){
                var datosDelTurno = {
                    IdPaciente: $('#IdPaciente').val(),
                    IdMedico: $('#IdMedico').val(),
                    FechaHoraInicio: $('#txtFechaHoraInicio').val(),
                    FechaHoraFin: ");
                WriteLiteral(@"$('#txtFechaHoraFin').val(),
                }
                GrabarTurno(datosDelTurno);
            })
                
            function GrabarTurno(data){
                $.ajax({
                    type: ""POST"",
                    url: ""Turno/GrabarTurno"",
                    data: {'turno': data},
                    headers: {'RequestVerificationToken': $('input[name=""__RequestVerificationToken""]').val()},
                    success: function (e){
                        if (e.ok){
                            ObtenerTurnosYActualizar($('#IdMedico').val());
                        }
                    },
                    error: function(){
                        alert('Error al Grabar Turno');
                    }
                })
            }

            $('#btnEliminar').click(function(){
                if (confirm('Esta seguro de eliminar el turno?')){
                    $.ajax({
                        type: ""POST"",
                        url: ""Turno/Eli");
                WriteLiteral(@"minarTurno"",
                        data: {'IdTurno': turnoSeleccionado.idTurno},
                        headers: {'RequestVerificationToken': $('input[name=""__RequestVerificationToken""]').val()},
                        success: function(e){
                            if (e.ok){
                                ObtenerTurnosYActualizar($('#IdMedico').val());
                            }
                        },
                        error: function(){
                            alert('Error al eliminar el Turno');
                        }
                    })
                }
            })
    
        })

</script>
");
            }
            );
            WriteLiteral("</br>\r\n</br>\r\n</br>\r\n</br>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Turnos.Models.Turno> Html { get; private set; }
    }
}
#pragma warning restore 1591
