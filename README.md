# POST https://veriscanonline.com/Authorize
## Request Information
### Body Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|UserName||string|Required|
|Password||string|Required|

## Response Information
Cookies

# Request Headers
## Required Header
prevent redirect to login page when request was not authorized

|Name|Value|
|-----|------|
|X-Requested-With|XMLHttpRequest|

# GET (POST) https://veriscanonline.com/Export/History?from={from}&to={to}&search={search}&skip={skip}&take={take}
History log. Maximum 1000 rows
## Request Information
Cookies
### URI (Body) Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|from||DateTime|Required|
|to||DateTime|Required|
|search||string||
|skip||int?||
|take||int?||

## Response Information
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|HistoryItems||Collection of HistoryItem||

## HistoryItem
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|Id||int||
|CustomId||string||
|Scanned||DateTime|
|ScannedLocal||DateTime|
|TimeZoneId||string|
|IDNum||string||
|FirstName||string||
|MiddleName||string|
|LastName||string||
|ExpDate||int||
|Address1||string||
|Address2||string||
|Address||string||
|City||string||
|JurisdictionCode|state|string||
|PostalCode||string||
|Country||string||
|CountryCode||string||
|Gender||string||
|DeviceName||string||
|LocationName||string||
|Phone||string||
|Email||string||
|GroupComment||string||
|GroupName||string||
|Tags||string||
|Comments||string||
|CompletedSurveys||string|Collection of CompletedSurvey|
|CustomFieldValues||string|Collection of CustomFieldValue|

## CustomFieldValue
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|SurveyID||int||

## CompletedSurvey
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|FieldId||int||
|CategoryId||int?||
|CategoryName||string||
|TypeId||int||
|TypeName||string||
|FieldName||string||
|Value||string||
|OptionIds||Collection of int||

## Response Formats
### Default
```xml
<HistoryLog xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
<HistoryItem id="4071544">
<Scanned>2016-01-12T21:57:23.277</Scanned>
<IDNum>9999991</IDNum>
<FirstName>I</FirstName>
<MiddleName>AM</MiddleName>
<LastName>SAMPLE</LastName>
<BirthDate>1980-01-05T06:00:00</BirthDate>
<ExpDate>2012-05-12T05:00:00</ExpDate>
<Address>10 HOPE STREET</Address>
<City>PAWTUCKET</City>
<JurisdictionCode>RI</JurisdictionCode>
<PostalCode>02860</PostalCode>
<Gender>Female</Gender>
<DeviceName>Alycia's iPhone</DeviceName>
<LocationName>Demo</LocationName>
<Phone/>
<Email/>
<GroupComment/>
<GroupName>Banned</GroupName>
<Tags/>
<Comments/>
<CompletedSurveys>
<SurveyId>49</SurveyId>
<SurveyId>51</SurveyId>
</CompletedSurveys>
</HistoryItem>
<HistoryItem id="4047838">
</HistoryLog>
```

### Accept: application/json
```json
{
  "HistoryItems": [
    {
      "Id": 4071544,
      "Scanned": "/Date(1452657443277)/",
      "IDNum": "9999991",
      "FirstName": "I",
      "MiddleName": "AM",
      "LastName": "SAMPLE",
      "BirthDate": "/Date(315921600000)/",
      "ExpDate": "/Date(1336816800000)/",
      "Address": "10 HOPE STREET",
      "City": "PAWTUCKET",
      "JurisdictionCode": "RI",
      "PostalCode": "02860",
      "Gender": "Female",
      "DeviceName": "Alycia's iPhone",
      "LocationName": "Demo",
      "Phone": "",
      "Email": "",
      "GroupComment": "",
      "GroupName": "Banned",
      "Tags": "",
      "Comments": "",
      "CompletedSurveys": []
    }
  ]
}
```

# GET (POST) https://veriscanonline.com/Export/Scan?customId={customId}
History Log Scan.
## Request Information
Cookies
### URI (Body) Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|customId||string|Required|

## Response Information
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|HistoryItem||HistoryItem||

## Response Formats
### Default
```xml
<HistoryLog xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
<HistoryItem id="4071544">
<Scanned>2016-01-12T21:57:23.277</Scanned>
<IDNum>9999991</IDNum>
<FirstName>I</FirstName>
<MiddleName>AM</MiddleName>
<LastName>SAMPLE</LastName>
<BirthDate>1980-01-05T06:00:00</BirthDate>
<ExpDate>2012-05-12T05:00:00</ExpDate>
<Address>10 HOPE STREET</Address>
<City>PAWTUCKET</City>
<JurisdictionCode>RI</JurisdictionCode>
<PostalCode>02860</PostalCode>
<Gender>Female</Gender>
<DeviceName>Alycia's iPhone</DeviceName>
<LocationName>Demo</LocationName>
<Phone/>
<Email/>
<GroupComment/>
<GroupName>Banned</GroupName>
<Tags/>
<Comments/>
<CompletedSurveys>
<SurveyId>49</SurveyId>
<SurveyId>51</SurveyId>
</CompletedSurveys>
</HistoryItem>
<HistoryItem id="4047838">
</HistoryLog>
```

### Accept: application/json
```json
{
  "HistoryItems": [
    {
      "Id": 4071544,
      "Scanned": "/Date(1452657443277)/",
      "IDNum": "9999991",
      "FirstName": "I",
      "MiddleName": "AM",
      "LastName": "SAMPLE",
      "BirthDate": "/Date(315921600000)/",
      "ExpDate": "/Date(1336816800000)/",
      "Address": "10 HOPE STREET",
      "City": "PAWTUCKET",
      "JurisdictionCode": "RI",
      "PostalCode": "02860",
      "Gender": "Female",
      "DeviceName": "Alycia's iPhone",
      "LocationName": "Demo",
      "Phone": "",
      "Email": "",
      "GroupComment": "",
      "GroupName": "Banned",
      "Tags": "",
      "Comments": "",
      "CompletedSurveys": []
    }
  ]
}
```

# GET (POST) https://veriscanonline.com/Export/SurveysList?active={active}
Collection of surveys
## Request Information
Cookies
### URI (Body) Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|active||bool?|default true|

## Response Information
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|Surveys||Collection of Survey||

## Survey
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|IsActive||bool||
|SurveyName||bool||
|SurveyId||int||
|Created||DateTime||
|Questions||Collection of Question||

## Question
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|QuestionId||int||
|QuestionText||string||
|QuestionType||string||
|Answers||Collection of Answer||

## Answer
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|AnswerId||int||
|AnswerText||string||

## Response Formats
### Default
```xml
<?xml version="1.0" encoding="utf-8"?>
<SurveysList xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <Surveys>
    <Survey SurveyId="1" Created="2016-01-26T06:53:00">
      <SurveyName>survey</SurveyName>
      <IsActive>true</IsActive>
      <Questions>
        <Question QuestionId="1">
          <QuestionType>Multiple Choice Checkboxes</QuestionType>
          <QuestionText>Multiple Choice Checkboxes? </QuestionText>
          <Answers>
            <Answer AnswerId="1">Multiple Choice Checkboxes 1</Answer>
            <Answer AnswerId="2">Multiple Choice Checkboxes 2</Answer>
            <Answer AnswerId="3">Multiple Choice Checkboxes 3</Answer>
          </Answers>
        </Question>
        <Question QuestionId="9">
          <QuestionType>Email</QuestionType>
          <QuestionText>Email ?</QuestionText>
          <Answers />
        </Question>
        <Question QuestionId="10">
          <QuestionType>Dropdown</QuestionType>
          <QuestionText>Dropdown ?</QuestionText>
          <Answers>
            <Answer AnswerId="17">Dropdown 1</Answer>
            <Answer AnswerId="18">Dropdown 2</Answer>
            <Answer AnswerId="19">Dropdown 3</Answer>
          </Answers>
        </Question>
      </Questions>
    </Survey>
  </Surveys>
</SurveysList>
```

### Accept: application/json
```json
{
  "Surveys": [
    {
      "SurveyId": 1,
      "SurveyName": "survey",
      "IsActive": true,
      "Created": "/Date(1453812780000)/",
      "Questions": [
        {
          "QuestionId": 1,
          "QuestionType": "Multiple Choice Checkboxes",
          "QuestionText": "Multiple Choice Checkboxes? ",
          "Answers": [
            {
              "AnswerId": 1,
              "AnswerText": "Multiple Choice Checkboxes 1"
            },
            {
              "AnswerId": 2,
              "AnswerText": "Multiple Choice Checkboxes 2"
            },
            {
              "AnswerId": 3,
              "AnswerText": "Multiple Choice Checkboxes 3"
            }
          ]
        },
        {
          "QuestionId": 9,
          "QuestionType": "Email",
          "QuestionText": "Email ?",
          "Answers": []
        },
        {
          "QuestionId": 10,
          "QuestionType": "Dropdown",
          "QuestionText": "Dropdown ?",
          "Answers": [
            {
              "AnswerId": 17,
              "AnswerText": "Dropdown 1"
            },
            {
              "AnswerId": 18,
              "AnswerText": "Dropdown 2"
            },
            {
              "AnswerId": 19,
              "AnswerText": "Dropdown 3"
            }
          ]
        }        
      ]
    }
  ]
}
```

# GET (POST) https://veriscanonline.com/Export/Survey?surveyid={surveyid}
Responses to survey
## Request Information
Cookies
### URI (Body) Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|surveyid||int|required|
|from||DateTime?||
|to||DateTime?|
|skip||int?||
|take||int?||

## Response Information
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|SurveyName||string||
|IsActive||bool||
|Questions||Collection of Question||
|Responses||Collection of Response||

## Question
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|QuestionId||int||
|QuestionText||string||

## Response
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|HistoryLogId||int||
|FirstName||string||
|LastName||string||
|MiddleName||string||
|Scanned||DateTime||
|FirstName||string||
|ResponsesToQuestions||Collection of |ResponseToQuestion|

## ResponseToQuestion
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|QuestionId||int||
|TextResponse||string||

## Response Formats
### Default
```xml
<?xml version="1.0" encoding="utf-8"?>
<Survey xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" SurveyId="1">
  <SurveyName>survey</SurveyName>
  <IsActive>true</IsActive>
  <Questions>
    <Question QuestionId="1">Multiple Choice Checkboxes? </Question>
    <Question QuestionId="9">Email ?</Question>
    <Question QuestionId="10">Dropdown ?</Question>
  </Questions>
  <Responses>
    <Response HistoryLogId="7415394" Scanned="2017-01-18T06:33:36.32" FirstName="SAMPLE" MiddleName="DRIVER" LastName="LICENSE">
      <ResponseToQuestion QuestionId="1">Multiple Choice Checkboxes 1; Multiple Choice Checkboxes 2</ResponseToQuestion>
      <ResponseToQuestion QuestionId="9" />
      <ResponseToQuestion QuestionId="10" />
    </Response>
    <Response HistoryLogId="6476892" Scanned="2016-10-06T07:30:31.307" FirstName="I AM" MiddleName="A" LastName="SAMPLE">
      <ResponseToQuestion QuestionId="1">Multiple Choice Checkboxes 5</ResponseToQuestion>
      <ResponseToQuestion QuestionId="9" />
      <ResponseToQuestion QuestionId="10">Dropdown 9</ResponseToQuestion>
    </Response>
    <Response HistoryLogId="4751803" Scanned="2016-04-07T13:58:10.05" FirstName="FRED" MiddleName="" LastName="GARCIA">
      <ResponseToQuestion QuestionId="1">Multiple Choice Checkboxes 3</ResponseToQuestion>
      <ResponseToQuestion QuestionId="9" />
      <ResponseToQuestion QuestionId="10" />
    </Response>    
  </Responses>
</Survey>
```
### Accept: application/json
```json
{
  "SurveyId": 1,
  "SurveyName": "survey",
  "IsActive": true,
  "Questions": [
    {
      "QuestionId": 1,
      "QuestionText": "Multiple Choice Checkboxes? "
    },
    {
      "QuestionId": 9,
      "QuestionText": "Email ?"
    },
    {
      "QuestionId": 10,
      "QuestionText": "Dropdown ?"
    }
  ],
  "Responses": [
    {
      "HistoryLogId": 7415394,
      "Scanned": "\/Date(1484742816320)\/",
      "FirstName": "SAMPLE",
      "MiddleName": "DRIVER",
      "LastName": "LICENSE",
      "ResponsesToQuestions": [
        {
          "QuestionId": 1,
          "TextResponse": "Multiple Choice Checkboxes 1; Multiple Choice Checkboxes 2"
        },
        {
          "QuestionId": 9,
          "TextResponse": ""
        },
        {
          "QuestionId": 10,
          "TextResponse": ""
        }
      ]
    },
    {
      "HistoryLogId": 6476892,
      "Scanned": "\/Date(1475757031307)\/",
      "FirstName": "I AM",
      "MiddleName": "A",
      "LastName": "SAMPLE",
      "ResponsesToQuestions": [
        {
          "QuestionId": 1,
          "TextResponse": "Multiple Choice Checkboxes 5"
        },
        {
          "QuestionId": 9,
          "TextResponse": ""
        },
        {
          "QuestionId": 10,
          "TextResponse": "Dropdown 9"
        }
      ]
    },
    {
      "HistoryLogId": 4751803,
      "Scanned": "\/Date(1460055490050)\/",
      "FirstName": "FRED",
      "MiddleName": "",
      "LastName": "GARCIA",
      "ResponsesToQuestions": [
        {
          "QuestionId": 1,
          "TextResponse": "Multiple Choice Checkboxes 3"
        },
        {
          "QuestionId": 9,
          "TextResponse": ""
        },
        {
          "QuestionId": 10,
          "TextResponse": ""
        }
      ]
    }
  ]
}
```

# https://veriscanonline.com/Export/HistoryLogResponses?historyId={historyId}
Response to history log
## Request Information
Cookies

### URI (Body) Parameters
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|historyId||int|required|

## Response Information
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|HistoryLogId||int||
|FirstName||string||
|LastName||string||
|MiddleName||string||
|Scanned||DateTime||
|Surveys||Collection of Survey||

## Survey
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|SurveyId||int||
|SurveyName||string||
|IsActive||bool||
|Responses||Collection of Response||

## Response
|Name|Description|Type|Additional information|
|-----|-------|-----|-----------|
|QuestionId||int||
|QuestionText||string||
|TextResponse||bool||

## Response Formats
### Default
```xml
<?xml version="1.0" encoding="utf-8"?>
<HistoryLogResponses xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" HistoryLogId="4751803" Scanned="2016-04-07T13:58:10.05" FirstName="FRED" MiddleName="GARCIA" LastName="GARCIA">
  <Surveys>
    <Survey SurveyId="1">
      <SurveyName>survey</SurveyName>
      <IsActive>true</IsActive>
      <Responses>
        <Response QuestionId="1">
          <QuestionText>Multiple Choice Checkboxes? </QuestionText>
          <TextResponse>Multiple Choice Checkboxes 3</TextResponse>
        </Response>
        <Response QuestionId="9">
          <QuestionText>Email ?</QuestionText>
        </Response>
        <Response QuestionId="10">
          <QuestionText>Dropdown ?</QuestionText>
        </Response>
        <Response QuestionId="11">
          <QuestionText>Multiple Choice Radio ?</QuestionText>
        </Response>
        <Response QuestionId="12">
          <QuestionText>Date ?</QuestionText>
        </Response>
        <Response QuestionId="13">
          <QuestionText>Textbox ?</QuestionText>
        </Response>
        <Response QuestionId="14">
          <QuestionText>Textarea ?</QuestionText>
        </Response>
      </Responses>
    </Survey>
  </Surveys>
</HistoryLogResponses>
```

### Accept: application/json
```json
{
  "HistoryLogId": 4751803,
  "Scanned": "/Date(1460055490050)/",
  "FirstName": "FRED",
  "MiddleName": "GARCIA",
  "LastName": "GARCIA",
  "Surveys": [
    {
      "SurveyId": 1,
      "SurveyName": "survey",
      "IsActive": true,
      "Responses": [
        {
          "QuestionId": 1,
          "QuestionText": "Multiple Choice Checkboxes? ",
          "TextResponse": "Multiple Choice Checkboxes 3"
        },
        {
          "QuestionId": 9,
          "QuestionText": "Email ?",
          "TextResponse": null
        },
        {
          "QuestionId": 10,
          "QuestionText": "Dropdown ?",
          "TextResponse": null
        },
        {
          "QuestionId": 11,
          "QuestionText": "Multiple Choice Radio ?",
          "TextResponse": null
        },
        {
          "QuestionId": 12,
          "QuestionText": "Date ?",
          "TextResponse": null
        },
        {
          "QuestionId": 13,
          "QuestionText": "Textbox ?",
          "TextResponse": null
        },
        {
          "QuestionId": 14,
          "QuestionText": "Textarea ?",
          "TextResponse": null
        }
      ]
    }
  ]
}
```
