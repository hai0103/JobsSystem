$(document).ready(function () {
    var candidate = new Candidate();
})

class Candidate {
    constructor() {
        this.InitEvents(); 
    }

    InitEvents() {
        $(document).on('click', '#getall', this.getall.bind(this));
    }

    getall() {
        $.ajax({
            method: 'get',
            async: false,
            url: '/api/Candidate',
            success: function (res) {
                console.log(res);
                debugger
            },
            error: function (res) {
                console.log(res);
            }

        })
    }

}