﻿<?xml version="1.0" encoding="utf-8"?>
<profile dslVersion="1.0.0.0" name="CqrsProfile" displayName="Cqrs Profile" xmlns="http://schemas.microsoft.com/UML2.1.2/ProfileDefinition">
  <stereotypes>
    <stereotype name="Domain" displayName="Domain">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IPackage" />
      </metaclasses>
    </stereotype>
    <stereotype name="Module" displayName="Module">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IPackage" />
      </metaclasses>
    </stereotype>

    <stereotype name="Html" displayName="Html">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Json" displayName="Json">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <stereotype name="Proposed" displayName="Proposed" >
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IPackage" />
      </metaclasses>
    </stereotype>
    <stereotype name="AggregateRoot" displayName="Aggregate Root">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
      <properties>
        <property name="BuildCreateEvent" displayName="BuildCreateEvent: Automatically adds a Create method, event and command" defaultValue="true">
          <propertyType>
            <externalTypeMoniker name="/CqrsProfile/System.Boolean"/>
          </propertyType>
        </property>
        <property name="BuildUpdateEvent" displayName="BuildUpdateEvent: Automatically adds a Update method, event and command" defaultValue="true">
          <propertyType>
            <externalTypeMoniker name="/CqrsProfile/System.Boolean"/>
          </propertyType>
        </property>
        <property name="BuildDeleteEvent" displayName="BuildDeleteEvent: Automatically adds a Delete method, event and command" defaultValue="true">
          <propertyType>
            <externalTypeMoniker name="/CqrsProfile/System.Boolean"/>
          </propertyType>
        </property>
      </properties>
    </stereotype>
    <stereotype name="Entity" displayName="Entity">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ValueObject" displayName="Value Object">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="AggregateId" displayName="AggregateId">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IProperty" />
      </metaclasses>
    </stereotype>

    <stereotype name="Command" displayName="Command">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Event" displayName="Event">
      <metaclasses>
        <metaclassMoniker name="/CqrsProfile/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

  </stereotypes>

  <metaclasses>
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IClass" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IDependency" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IEnumeration" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IInterface" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IOperation" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IPackage" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IPackageImport" />
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IProperty" />
  </metaclasses>

  <propertyTypes>
    <externalType name="System.Object" />
    <externalType name="System.String" />
    <externalType name="System.Boolean" />
    <externalType name="System.DateTime" />
    <externalType name="System.Type" />

    <enumerationType name="PermissionScope">
      <enumerationLiterals>
        <enumerationLiteral name="User" displayName="User" />
        <enumerationLiteral name="Any" displayName="Any" />
      </enumerationLiterals>
    </enumerationType>
  </propertyTypes>
</profile>