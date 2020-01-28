import "./css/main.css";
import * as signalR from "@microsoft/signalr";
import * as $ from 'jquery';
import {DefiCOMEmulatorStatus} from './model/DefiCOMEmulatorStatus';

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

window.onload = function()
{
    connection.on("parameterUpdated", (code:string, value:number) =>
    {
        switch(code)
        {
            case "Manifold_Absolute_Pressure":
                $('#boostSlider').prop('value', value);
                $('#boostLabel').text(value);
                break;
            case "Engine_Speed":
                $('#rpmSlider').prop('value', value);
                $('#rpmLabel').text(value);
                break;
            case "Oil_Pressure":
                $('#oilpresSlider').prop('value', value);
                $('#oilpresLabel').text(value);
                break;
            case "Fuel_Rail_Pressure":
                $('#fuelpresSlider').prop('value', value);
                $('#fuelpresLabel').text(value);
                break;
            case "Exhaust_Gas_Temperature":
                $('#exttempSlider').prop('value', value);
                $('#exttempLabel').text(value);
                break;
            case "Oil_Temperature":
                $('#oiltempSlider').prop('value', value);
                $('#oiltempLabel').text(value);
                break;
            case "Coolant_Temperature":
                $('#watertempSlider').prop('value', value);
                $('#watertempLabel').text(value);
                break;
            default:
                throw Error("Parameter code does not match on parameterUpdated.");
        }
    });

    connection.on("emulatorStartStopped", (comportName:string, isrunning:boolean, iserror:boolean, alertmessage:string) =>
    {
        $('#comportNameInput').val(comportName);
        $('#btnStart').prop('disabled', !isrunning);
        if(iserror)
        {
            alert(alertmessage);
        }
    });

    connection.start().catch(err => {throw Error(err)});
    $('#boostSlider').on('input', () => connection.send("updateParameter", "Manifold_Absolute_Pressure", $('#boostSlider').val()));
    $('#rpmSlider').on('input', () => connection.send("updateParameter", "Engine_Speed", $('#rpmSlider').val()));
    $('#oilpresSlider').on('input', () => connection.send("updateParameter", "Oil_Pressure", $('#oilpresSlider').val()));
    $('#fuelpresSlider').on('input', () => connection.send("updateParameter", "Fuel_Rail_Pressure", $('#fuelpresSlider').val()));
    $('#exttempSlider').on('input', () => connection.send("updateParameter", "Exhaust_Gas_Temperature", $('#exttempSlider').val()));
    $('#oiltempSlider').on('input', () => connection.send("updateParameter", "Oil_Temperature", $('#oiltempSlider').val()));
    $('#watertempSlider').on('input', () => connection.send("updateParameter", "Coolant_Temperature", $('#watertempSlider').val()));
 
    $.getJSON('DefiEmulator/EmulatorStatus/', null, (emuStatus : DefiCOMEmulatorStatus) =>
    {
        setEmustatus(emuStatus);
    });

    $('#btnStart').on('click', ()=> connection.send("startDefiEmulator", $('#comportNameInput').val()));
};

function setEmustatus(emuStatus : DefiCOMEmulatorStatus)
{
    $('#btnStart').prop('disabled', !emuStatus.isRunning);
    $('#comportNameInput').prop('value', emuStatus.comPortName);

    $('#boostSlider').prop('value', emuStatus.defiCOMParameter["Manifold_Absolute_Pressure"]);
    $('#boostLabel').text(emuStatus.defiCOMParameter["Manifold_Absolute_Pressure"]);
    
    $('#rpmSlider').prop('value', emuStatus.defiCOMParameter["Engine_Speed"]);
    $('#rpmLabel').text(emuStatus.defiCOMParameter["Engine_Speed"]);
    
    $('#oilpresSlider').prop('value', emuStatus.defiCOMParameter["Oil_Pressure"]);
    $('#oilpresLabel').text(emuStatus.defiCOMParameter["Oil_Pressure"]);
    
    $('#fuelpresSlider').prop('value', emuStatus.defiCOMParameter["Fuel_Rail_Pressure"]);
    $('#fuelpresLabel').text(emuStatus.defiCOMParameter["Fuel_Rail_Pressure"]);
    
    $('#exttempSlider').prop('value', emuStatus.defiCOMParameter["Exhaust_Gas_Temperature"]);
    $('#exttempLabel').text(emuStatus.defiCOMParameter["Exhaust_Gas_Temperature"]);
    
    $('#oiltempSlider').prop('value', emuStatus.defiCOMParameter["Oil_Temperature"]);
    $('#oiltempLabel').text(emuStatus.defiCOMParameter["Oil_Temperature"]);
    
    $('#watertempSlider').prop('value', emuStatus.defiCOMParameter["Coolant_Temperature"]);
    $('#watertempLabel').text(emuStatus.defiCOMParameter["Coolant_Temperature"]);
}
