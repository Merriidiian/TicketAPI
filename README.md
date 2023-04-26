Test JSON's
'''
1.
{
    "operation_type": "sale",
    "operation_time": "2022-01-02T03:25+03:00",
    "operation_place": "Pobeda",
    "passenger": {
        "name": "Ilya",
        "surname": "Serdyukov",
        "patronymic": "Alexsandrovich",
        "doc_type": "00",
        "doc_number": "3108111435",
        "birthdate": "2001-12-11",
        "gender": "M",
        "passenger_type": "youth",
        "ticket_number": "5552139265673",
        "ticket_type": 1
    },
    "routes": [{
            "airline_code": "SU",
            "flight_num": 1713,
            "depart_place": "AAQ",
            "depart_datetime": "2022-01-03T09:20+10:00",
            "arrive_place": "NSK",
            "arrive_datetime": "2022-01-03T11:25+03:00",
            "pnr_id": "THALSZ"
        }, {
            "airline_code": "SU",
            "flight_num": 1714,
            "depart_place": "NSK",
            "depart_datetime": "2022-01-08T16:10+03:00",
            "arrive_place": "AAQ",
            "arrive_datetime": "2022-01-08T07:40+10:00",
            "pnr_id": "THALSZ"
        }
    ]
}
2. 
{
    "operation_type": "sale",
    "operation_time": "2022-01-01T03:25+03:00",
    "operation_place": "Aeroflot",
    "passenger": {
        "name": "Dmitrii",
        "surname": "Makarov",
        "patronymic": "Pavlovich",
        "doc_type": "00",
        "doc_number": "3108111434",
        "birthdate": "2001-07-12",
        "gender": "M",
        "passenger_type": "youth",
        "ticket_number": "5552139265672",
        "ticket_type": 1
    },
    "routes": [{
            "airline_code": "SU",
            "flight_num": 1701,
            "depart_place": "AAQ",
            "depart_datetime": "2022-01-02T09:20+10:00",
            "arrive_place": "NSK",
            "arrive_datetime": "2022-01-02T11:25+03:00",
            "pnr_id": "THALSZ"
        }, {
            "airline_code": "SU",
            "flight_num": 1702,
            "depart_place": "NSK",
            "depart_datetime": "2022-01-05T16:10+03:00",
            "arrive_place": "AAQ",
            "arrive_datetime": "2022-01-05T07:40+10:00",
            "pnr_id": "THALSZ"
        }
    ]
}
3.
{
    "operation_type": "sale",
    "operation_time": "2022-12-12T03:25+03:00",
    "operation_place": "Emirates",
    "passenger": {
        "name": "Polina",
        "surname": "Melnichuk",
        "patronymic": "Maksimovna",
        "doc_type": "00",
        "doc_number": "3108111437",
        "birthdate": "2001-03-05",
        "gender": "F",
        "passenger_type": "youth",
        "ticket_number": "5552139265679",
        "ticket_type": 1
    },
    "routes": [{
            "airline_code": "SU",
            "flight_num": 1790,
            "depart_place": "AAQ",
            "depart_datetime": "2022-12-12T09:20+10:00",
            "arrive_place": "NSK",
            "arrive_datetime": "2022-12-12T11:25+03:00",
            "pnr_id": "THALSZ"
        }, {
            "airline_code": "SU",
            "flight_num": 1791,
            "depart_place": "NSK",
            "depart_datetime": "2022-11-11T16:10+03:00",
            "arrive_place": "AAQ",
            "arrive_datetime": "2022-11-11T07:40+10:00",
            "pnr_id": "THALSZ"
        }
    ]
}
4.
{
    "operation_type": "refund",
    "operation_time": "2022-12-12T03:25+03:00",
    "operation_place": "Emirates",
"ticket_number": "5552139265679"
}
'''
