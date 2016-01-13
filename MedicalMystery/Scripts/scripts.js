$(function() {
    $('#readmoremodal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget); // Button that triggered the modal
        var name = button.data('name'); // Extract info from data-* attributes
        var desc = button.data('description'); // Extract info from data-* attributes
        var doctor = button.data('doctor'); // Extract info from data-* attributes
        // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
        // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
        var modal = $(this);
        modal.find('.modal-title').text('' + name);
        modal.find('.modal-doctor').text(doctor);
        modal.find('.modal-body').text(desc);
    });
});