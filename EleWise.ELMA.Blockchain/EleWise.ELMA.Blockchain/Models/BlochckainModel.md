<?xml version="1.0" encoding="utf-8"?>
<Entity xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Uid>184adc37-4d4f-4aa9-a977-719e81c30618</Uid>
  <Name>BlochckainModel</Name>
  <DisplayName>BlochckainModel</DisplayName>
  <Images />
  <NamedImages />
  <Namespace>EleWise.ELMA.Blockchain.Models</Namespace>
  <BaseClassUid>00000000-0000-0000-0000-000000000000</BaseClassUid>
  <Properties>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>54294fd4-a17a-40ff-b86a-ee8d597c96e9</Uid>
      <Name>Uid</Name>
      <DisplayName>Уникальный идентификатор</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>eb6e8ddc-fafe-4e0e-9018-1a7667012579</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="GuidSettings">
        <FieldName>Uid</FieldName>
      </Settings>
      <Nullable>false</Nullable>
      <IsSystem>true</IsSystem>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <Visibility>Hidden</Visibility>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>0</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>c0cfb26e-eb57-4cc7-a32c-294127aefe97</Uid>
      <Name>FormId</Name>
      <DisplayName>От кого</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>FormId</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>1</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>b3d59cf0-952d-4fb7-b8fb-ade098e54430</Uid>
      <Name>ToId</Name>
      <DisplayName>Кому</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>9b9aac17-22bb-425c-aa93-9c02c5146965</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="StringSettings">
        <FieldName>ToId</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>2</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
    </PropertyMetadata>
    <PropertyMetadata xsi:type="EntityPropertyMetadata">
      <Uid>c94bf62e-ee3b-49fd-8c9d-65255856628c</Uid>
      <Name>Amount</Name>
      <DisplayName>Сумма</DisplayName>
      <Images />
      <NamedImages />
      <TypeUid>d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7</TypeUid>
      <SubTypeUid>00000000-0000-0000-0000-000000000000</SubTypeUid>
      <Settings xsi:type="DoubleSettings">
        <FieldName>Amount</FieldName>
      </Settings>
      <Nullable>true</Nullable>
      <OwnerPropertyUid>00000000-0000-0000-0000-000000000000</OwnerPropertyUid>
      <ViewSettings>
        <Attributes>
          <ViewAttribute>
            <ViewType>Create</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Edit</ViewType>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Display</ViewType>
            <ReadOnly>true</ReadOnly>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>List</ViewType>
            <Visibility>Hidden</Visibility>
          </ViewAttribute>
          <ViewAttribute>
            <ViewType>Filter</ViewType>
          </ViewAttribute>
        </Attributes>
      </ViewSettings>
      <Order>3</Order>
      <Handlers />
      <TypeResolver>00000000-0000-0000-0000-000000000000</TypeResolver>
    </PropertyMetadata>
  </Properties>
  <DefaultForms>
    <CreateUid>00000000-0000-0000-0000-000000000000</CreateUid>
    <EditUid>00000000-0000-0000-0000-000000000000</EditUid>
    <DisplayUid>00000000-0000-0000-0000-000000000000</DisplayUid>
    <ActionGuids />
    <FormSettings />
  </DefaultForms>
  <Forms />
  <FormTransformations />
  <FormViews />
  <TableViews>
    <TableView>
      <Uid>2c7591cd-8d23-4b4b-b7e3-77b2435b42d0</Uid>
      <ViewType>List</ViewType>
      <SortDescriptors />
      <GroupDescriptors />
    </TableView>
  </TableViews>
  <TitlePropertyUid>00000000-0000-0000-0000-000000000000</TitlePropertyUid>
  <Type>Interface</Type>
  <ImplementationUid>51af4987-8775-4641-9548-dfbaf1f60cd6</ImplementationUid>
  <IdTypeUid>d90a59af-7e47-48c5-8c4c-dad04834e6e3</IdTypeUid>
  <TableName>BlochckainModel</TableName>
  <IsSoftDeletable>true</IsSoftDeletable>
  <ParentPropertyUid>00000000-0000-0000-0000-000000000000</ParentPropertyUid>
  <IsGroupPropertyUid>00000000-0000-0000-0000-000000000000</IsGroupPropertyUid>
  <Filter>
    <Uid>00000000-0000-0000-0000-000000000000</Uid>
    <Images />
    <NamedImages />
    <BaseClassUid>00000000-0000-0000-0000-000000000000</BaseClassUid>
    <Properties />
    <DefaultForms>
      <CreateUid>00000000-0000-0000-0000-000000000000</CreateUid>
      <EditUid>00000000-0000-0000-0000-000000000000</EditUid>
      <DisplayUid>00000000-0000-0000-0000-000000000000</DisplayUid>
      <ActionGuids />
      <FormSettings />
    </DefaultForms>
    <Forms />
    <FormTransformations />
    <FormViews />
    <TableViews />
    <TitlePropertyUid>00000000-0000-0000-0000-000000000000</TitlePropertyUid>
  </Filter>
  <ImplementedExtensionUids />
  <Actions>
    <Uid>00000000-0000-0000-0000-000000000000</Uid>
    <Images />
    <NamedImages />
    <BaseTypeUid>00000000-0000-0000-0000-000000000000</BaseTypeUid>
    <Values />
  </Actions>
  <TableParts />
</Entity>