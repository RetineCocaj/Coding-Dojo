$(document).ready(function(){
    $('#add-class').click(function(){
        $('.add').before('<p>This class will be added by method addClass (this paragraph is added by before method)</p>');
        $('.add').addClass('red');
        $('.add').after('<p>Class red added (this paragraph is added by after method)</p>');
    })

    $('#slide-toggle').click(function(){
        $(this).toggleClass('.clicked');
        $('.hidden-img img').slideToggle();
    })

    $('#append').click(function(){
        $('.appended-p').append('<p>This is the appended paragraph!!!</p>');
    })

    $('#hide').click(function(){
        $('.hide-show').hide();
    })
    $('#show').on("click", function(){
        $('.hide-show').show();
    })

    $('#toggle').click(function(){
        $('.toggle').toggle();
    })

    $('#slide-up').click(function(){
        $('.slide-fade').slideUp();
    })
    $('#slide-down').click(function(){
        $('.slide-fade').slideDown();
    })
    $('#fade-in').click(function(){
        $('.slide-fade').fadeIn(3000);
    })
    $('#fade-out').click(function(){
        $('.slide-fade').fadeOut(3000);
    })

    $('.email').click(function(){
        var text = $(this).text();
        $('input').val(text);
        text = $('input').attr('type');
        $('.type').html('The type of this input is ' + text)
    })
})