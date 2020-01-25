export enum DefiParameterCode
{
    Manifold_Absolute_Pressure,
    Engine_Speed,
    Oil_Pressure,
    Fuel_Rail_Pressure,
    Exhaust_Gas_Temperature,
    Oil_Temperature,
    Coolant_Temperature
};

export class DefiCOMEmulatorStatus
{
    public DefiCOMParameter : {[code : string]: number;};
    public COMPortName : string;
    public IsRunning : boolean;
}